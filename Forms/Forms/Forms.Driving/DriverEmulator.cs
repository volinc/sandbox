using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Forms.Driving.Data;
using Forms.Driving.Domain.Entities;
using Forms.Driving.Infrastructure;
using Newtonsoft.Json;

namespace Forms.Driving
{
    public class DriverEmulator : IDisposable
    { 
        private readonly EmulatorConfig _emulatorConfig;
        private readonly DriverClient _driverClient;
        private readonly SignalRClient _signalRClient;
        private readonly NotificationEmulatorClient _notificationEmulatorClient;

        private DateTimeOffset _startAt;

        public DriverEmulator(EmulatorConfig emulatorConfig, DriverClient driverClient, SignalRClient signalRClient,
            NotificationEmulatorClient notificationEmulatorClient)
        {
            this._emulatorConfig = emulatorConfig;
            this._driverClient = driverClient;
            this._signalRClient = signalRClient;
            this._notificationEmulatorClient = notificationEmulatorClient;

            driverClient.LoggedOut += DriverClientOnLoggedOut;
        }

        private void DriverClientOnLoggedOut(object o, EventArgs eventArgs)
        {
            Console.WriteLine("Stop listening SignalR");
            _signalRClient.StopListening();
            Console.WriteLine("Signed out");
        }

        private static Random Random => new Random(DateTimeOffset.Now.Second);       

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            try
            {
                _startAt = DateTimeOffset.Now;
                Console.WriteLine($"Working with {_emulatorConfig.ApiAuthority}...");

                var phone = _emulatorConfig.Phone;
                var password = _emulatorConfig.Password;

                var isSigned = await TryLoginAsync(phone, password);
                if (!isSigned)
                {
                    await RegisterOrResetPasswordAsync(phone, password);
                    isSigned = await TryLoginAsync(phone, password);
                }

                if (isSigned)
                    await WorkAsync(cancellationToken);
                else
                    Console.WriteLine("Unable to sign in...");
            }
            catch (Exception exception)
            {
                Console.Error.WriteLine(exception.Message);
            }
            finally
            {                
                Console.WriteLine($"Started at {_startAt.ToString("G", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Uptime {(DateTimeOffset.Now - _startAt).ToString("G", CultureInfo.InvariantCulture)}");
            }
        }

        private async Task<bool> TryLoginAsync(string phone, string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                return false;

            try
            {
                await _driverClient.LogInAsync(phone, password);
                Console.WriteLine($"User {phone} is signed in...");
                return true;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return false;
            }
        }
        
        private async Task RegisterOrResetPasswordAsync(string phone, string password)
        {
            var notificationEmulatorError =
                $"Unable to get confirmation code from emulator {_emulatorConfig.ApiAuthorityEmulator}";

            var givenNames = Guid.NewGuid().ToString("N");
            var familyName = Guid.NewGuid().ToString("N");
            try
            {
                Console.WriteLine("Trying to register...");
                await _driverClient.RegisterDriverAsync(phone, givenNames, familyName);

                var conditional = await _notificationEmulatorClient.TryGetConfirmationCodeAsync(phone);
                if (!conditional.HasValue)
                    throw new InvalidOperationException(notificationEmulatorError);
               
                await _driverClient.ConfirmDriverAsync(phone, password, conditional.Value);
            }
            catch (ErrorResponseException errorResponseException)
            {
                Console.Error.WriteLine(errorResponseException.Message);
                Console.WriteLine("Trying to reset password...");
                await _driverClient.ResetPasswordAsync(phone);
                var conditional = await _notificationEmulatorClient.TryGetConfirmationCodeAsync(phone);
                if (!conditional.HasValue)
                    throw new InvalidOperationException(notificationEmulatorError);

                await _driverClient.ResetPasswordConfirmAsync(phone, conditional.Value, password);
            }
        }

        private async Task<ShiftData> ReadOrCreateShiftAsync()
        {
            var conditional = await _driverClient.TryReadStateObjectAsync();
            if (conditional.HasValue)
            {
                var stateObject = conditional.Value;
                if (stateObject.Shift != null)
                {
                    await _driverClient.ShiftContinueAsync();
                    return stateObject.Shift;
                }
            }
            
            var availableVehicles = (await _driverClient.ReadAllVehiclesAsync(true)).Items.ToArray();
            if (!availableVehicles.Any())
            {
                var vehicle = Vehicle.Map.From(new VehicleData
                {
                    RegistrationNumber = Guid.NewGuid().ToString("N"),
                    DraftLicenseNumber = Guid.NewGuid().ToString("N"),
                });
                var brands = (await _driverClient.ReadVehicleBrandsAsync()).Items.ToArray();
                var brand = brands[Random.Next(0, brands.Length - 1)];
                var models = (await _driverClient.ReadVehicleModelsAsync(brand.Id)).Items.ToArray();
                vehicle.Model = models[Random.Next(0, models.Length - 1)];
                var bodies = (await _driverClient.ReadVehicleBodiesAsync()).Items.ToArray();
                vehicle.Body = bodies[Random.Next(0, bodies.Length - 1)];
                var colors = (await _driverClient.ReadVehicleColorsAsync()).Items.ToArray();
                vehicle.Color = colors[Random.Next(0, colors.Length - 1)];
                await _driverClient.CreateVehicleAsync(vehicle);

                availableVehicles = (await _driverClient.ReadAllVehiclesAsync(true)).Items.ToArray();
            }

            var availableVehicleId = availableVehicles[Random.Next(0, availableVehicles.Length - 1)].Id;
            var shift = await _driverClient.ShiftStartAsync(availableVehicleId, new[] { 1 }, new[] { 8 });
            await _driverClient.ShiftContinueAsync();

            return shift;
        }

        private async Task WorkWithSignalRClientAsync()
        {
            Console.WriteLine("Start listening SignalR");
            await Task.Run(() =>
            {
                _signalRClient.StateChanged += async (sender, state) =>
                {
                    Console.WriteLine($"SignalRState {state}");
                    await Task.Delay(0);
                };

                _signalRClient.NewOffer += async (sender, data) =>
                {
                    try
                    {
                        var offerData = JsonConvert.SerializeObject(data);
                        Console.WriteLine(offerData);

                        await _driverClient.SuggestionDeclineAsync(data.SuggestionId);
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception.Message);
                    }
                };

                _signalRClient.StartListening();
            });
        }

        private async Task WorkAsync(CancellationToken cancellationToken)
        {
            try
            {
                var shift = await ReadOrCreateShiftAsync();
                Console.WriteLine($"{shift.VehicleColor.Name} {shift.VehicleModel.FullName} {shift.VehicleRegistrationNumber}");

                await WorkWithSignalRClientAsync().ConfigureAwait(false);

                var i = 0;
                while (_driverClient.IsLoggedIn && !cancellationToken.IsCancellationRequested)
                {
                    try
                    {                        
                        var shLat = Math.Truncate(Random.NextDouble() * 100) / 100000;
                        var shLon = Math.Truncate(Random.NextDouble() * 100) / 100000;

                        var tracking = new TrackingData
                        {
                            OrderId = null,
                            Index = null,
                            Location = new Location(_emulatorConfig.CenterLocation.Latitude + shLat, _emulatorConfig.CenterLocation.Longitude + shLon),
                            Timestamp = DateTimeOffset.UtcNow,
                        };

                        await _driverClient.ShiftUpdateLocationAsync(tracking);

                        Console.WriteLine($"{i++} {tracking.Location.Latitude},{tracking.Location.Longitude}\t{tracking.Timestamp.ToString("G", CultureInfo.InvariantCulture)}");
                        await Task.Delay(TimeSpan.FromSeconds(2), cancellationToken);
                    }
                    catch (TaskCanceledException taskCanceledException)
                    {
                        Console.WriteLine($"TaskCanceledException: {taskCanceledException.Message}");
                    }
                    catch (ErrorResponseException errorResponseException)
                    {
                        Console.WriteLine(errorResponseException.Message);
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception.Message);
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }            
        }

        public void Dispose()
        {
            _driverClient.LoggedOut -= DriverClientOnLoggedOut;
        }
    }
}
