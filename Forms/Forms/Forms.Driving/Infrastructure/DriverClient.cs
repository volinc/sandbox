using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Forms.Driving.Data;
using Forms.Driving.Domain.Entities;

namespace Forms.Driving.Infrastructure
{
    public class DriverClient : ServiceClient
    {
        public DriverClient(ServiceClientConfiguration configuration, TokenStore tokenStore, HttpMessageHandler authMessageHandler,
            IConnectivityService connectivityService, TaskQueue requestQueue)
            : base(configuration, authMessageHandler, tokenStore, connectivityService, requestQueue)
        {
        }

        public async Task LogInAsync(string username, string password, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                using (var httpClient = CreateClient(BaseUri, SpecTimeout))
                {
                    var response = await SendAsync(httpClient, HttpMethod.Put, "tokens", new
                        {
                            grant_type = "password",
                            username,
                            password

                        }, cancellationToken)
                        .GetContentAsync<TokenResponse>();

                    TokenStore.Update(response);
                    IsLoggedIn = true;
                }
            }
            catch
            {
                TokenStore.Clean();
                throw;
            }
        }

        public async Task LogOutAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            await DeleteAsync("tokens/current", cancellationToken, new[] { HttpStatusCode.Unauthorized });
            await ForceLogoutAsync(false, cancellationToken);
        }

        public async Task<ConditionalValue<DriverEntireStateData>> TryReadStateObjectAsync(CancellationToken? cancellationToken = null)
        {
            try
            {
                var stateObject = await GetAsync("accounts/current/synchronization", cancellationToken)
                    .GetContentAsync<DriverEntireStateData>();

                return new ConditionalValue<DriverEntireStateData>(stateObject);
            }
            catch
            {
                return ConditionalValue<DriverEntireStateData>.None;
            }            
        }

        public async Task<AccountData> GetCurrentAccountAsync(CancellationToken? cancellationToken = null)
        {
            return await GetAsync("accounts/current", cancellationToken).GetContentAsync<AccountData>();
        }

        public async Task RegisterDriverAsync(string phone, string givenNames, string familyName, CancellationToken? cancellationToken = null)
        {
            using (var httpClient = CreateClient(BaseUri, SpecTimeout))
            {
                await SendAsync(httpClient, HttpMethod.Post, "accounts/phone", new
                {
                    login = phone,
                    profile = new
                    {
                        givenNames,
                        familyName
                    }

                }, cancellationToken);
            }
        }

        public async Task ConfirmDriverAsync(string phone, string password, string code, CancellationToken? cancellationToken = null)
        {
            using (var httpClient = CreateClient(BaseUri, Timeout))
            {
                await SendAsync(httpClient, HttpMethod.Post, "accounts/phone/confirm", new
                {
                    phone,
                    password,
                    code

                }, cancellationToken);
            }
        }

        public async Task ResetPasswordAsync(string phone, CancellationToken? cancellationToken = null)
        {
            using (var httpClient = CreateClient(BaseUri, SpecTimeout))
            {
                await SendAsync(httpClient, HttpMethod.Post, "accounts/phone/recover", new
                {
                    phone

                }, cancellationToken);
            }            
        }

        public async Task ResetPasswordConfirmAsync(string phone, string code, string password, CancellationToken? cancellationToken = null)
        {
            using (var httpClient = CreateClient(BaseUri, SpecTimeout))
            {
                await SendAsync(httpClient, HttpMethod.Put, "accounts/phone/password", new
                {
                    phone,
                    code,
                    password,

                }, cancellationToken);                
            }            
        }

        public async Task InviteConfirmAsync(string phone, string code, string password,
            CancellationToken? cancellationToken = null)
        {
            using (var httpClient = CreateClient(BaseUri, SpecTimeout))
            {
                await SendAsync(httpClient, HttpMethod.Put, "accounts/phone/accept-invite", new
                {
                    phone,
                    code,
                    password,

                }, cancellationToken);
            }
        }

        public async Task<Slice<VehicleData>> ReadAllVehiclesAsync(bool? isAvailable = null, CancellationToken? cancellationToken = null)
        {
            var query = isAvailable.HasValue ? $"?isAvailable={isAvailable}" : string.Empty;

            return await GetAsync($"vehicles{query}", cancellationToken).GetContentAsync<Slice<VehicleData>>();
        }

        public async Task<ConditionalValue<VehicleData>> TryReadVehicleAsync(string registrationNumber, CancellationToken? cancellationToken = null)
        {
            if (string.IsNullOrWhiteSpace(registrationNumber))
                return ConditionalValue<VehicleData>.None;

            var conditional = await GetAsync($"vehicles/registration-number/{registrationNumber}/-", cancellationToken)
                .GetContentAsync<ConditionalValue<VehicleData>>();

            return conditional;
        }

        public async Task<VehicleData> ReadVehicleByIdAsync(long vehicleId, CancellationToken? cancellationToken = null)
        {
            return await GetAsync($"vehicles/{vehicleId}", cancellationToken).GetContentAsync<VehicleData>();
        }

        public async Task<ShiftData> ShiftStartAsync(long vehicleId, IEnumerable<int> paymentMethods, IEnumerable<int> vehicleClasses, CancellationToken? cancellationToken = null)
        {
            return await PostAsync("shifts", new
            {
                vehicleId,
                paymentMethods = paymentMethods.Select(x => new {Id = x}),
                vehicleClasses = vehicleClasses.Select(x => new {Id = x}),

            }, cancellationToken).GetContentAsync<ShiftData>();
        }

        public async Task ShiftCloseAsync(CancellationToken? cancellationToken = null)
        {
            await PutAsync("shifts/current/close", cancellationToken);
        }

        public async Task ShiftUpdateLocationAsync(TrackingData tracking, CancellationToken? cancellationToken = null)
        {
            await PutAsync("shifts/current/location", tracking, cancellationToken);
        }

        public async Task<ShiftData> ShiftPauseAsync(CancellationToken? cancellationToken = null)
        {
            return await PutAsync("shifts/current/pause", cancellationToken).GetContentAsync<ShiftData>();
        }

        public async Task<ShiftData> ShiftContinueAsync(CancellationToken? cancellationToken = null)
        {
            return await PutAsync("shifts/current/continue", cancellationToken).GetContentAsync<ShiftData>();
        }

        public async Task ShiftApproveActivityAsync(CancellationToken? cancellationToken = null)
        {
            await PutAsync("shifts/current/approve-activity", cancellationToken);
        }

        public async Task<OrderData> SuggestionAcceptAsync(long suggestionId, CancellationToken? cancellationToken = null)
        {
            return await PostAsync($"orders/suggestion-id/{suggestionId}/accept", cancellationToken).GetContentAsync<OrderData>();
        }

        public async Task SuggestionDeclineAsync(long suggestionId, CancellationToken? cancellationToken = null)
        {
            await PostAsync($"orders/suggestion-id/{suggestionId}/decline", cancellationToken);
        }

        public async Task<OrderData> OrderWaitAsync(CancellationToken? cancellationToken = null)
        {
            return await PostAsync("orders/current/wait", cancellationToken).GetContentAsync<OrderData>();
        }

        public async Task<OrderData> OrderExecuteAsync(CancellationToken? cancellationToken = null)
        {
            return await PostAsync("orders/current/execute", cancellationToken).GetContentAsync<OrderData>();
        }

        public async Task<OrderData> OrderFinishAsync(CancellationToken? cancellationToken = null)
        {
            return await PostAsync("orders/current/finish", cancellationToken).GetContentAsync<OrderData>();
        }

        public async Task<OrderData> OrderCloseAsync(CancellationToken? cancellationToken = null)
        {
            return await PostAsync("orders/current/close", cancellationToken).GetContentAsync<OrderData>();
        }

        public async Task<JsonArray<DirectoryItem>> ReadVehicleBodiesAsync(CancellationToken? cancellationToken = null)
        {
            return await GetAsync("vehicle-bodies", cancellationToken).GetContentAsync<JsonArray<DirectoryItem>>();
        }

        public async Task<JsonArray<DirectoryItem>> ReadVehicleBrandsAsync(CancellationToken? cancellationToken = null)
        {
            return await GetAsync("vehicle-brands", cancellationToken).GetContentAsync<JsonArray<DirectoryItem>>();
        }

        public async Task<JsonArray<VehicleModelData>> ReadVehicleModelsAsync(long brandId, CancellationToken? cancellationToken = null)
        {
            return await GetAsync($"vehicle-brands/{brandId}/vehicle-models", cancellationToken).GetContentAsync<JsonArray<VehicleModelData>>();
        }

        public async Task<JsonArray<DirectoryItem>> ReadVehicleClassesAsync(CancellationToken? cancellationToken = null)
        {
            return await GetAsync("vehicle-classes", cancellationToken).GetContentAsync<JsonArray<DirectoryItem>>();
        }

        public async Task<JsonArray<DirectoryItem>> ReadVehicleColorsAsync(CancellationToken? cancellationToken = null)
        {
            return await GetAsync("vehicle-colors", cancellationToken).GetContentAsync<JsonArray<DirectoryItem>>();
        }

        public async Task<JsonArray<DirectoryItem>> ReadPriceCalculationMethodsAsync(CancellationToken? cancellationToken = null)
        {
            return await GetAsync("price-calculation-methods", cancellationToken).GetContentAsync<JsonArray<DirectoryItem>>();
        }

        public async Task CreateVehicleAsync(Vehicle vehicle, CancellationToken? cancellationToken = null)
        {
            await PostAsync("vehicles", new
            {
                vehicle.Model,
                vehicle.Color,
                vehicle.Body,
                vehicle.RegistrationNumber,                
                vehicle.ManufactureYear,

            }, cancellationToken);
        }

        public async Task UpdateVehicleAsync(long vehicleId, Vehicle vehicle, CancellationToken? cancellationToken = null)
        {
            await PutAsync($"vehicles/{vehicleId}", new
            {
                vehicle.Model,
                vehicle.Color,
                vehicle.Body,
                vehicle.RegistrationNumber,                
                vehicle.ManufactureYear,

            }, cancellationToken);
        }

        public async Task DetachVehicleAsync(long vehicleId, CancellationToken? cancellationToken = null)
        {
            await PutAsync($"vehicles/{vehicleId}/detach", cancellationToken);
        }        
    }
}
