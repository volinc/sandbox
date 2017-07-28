namespace EF6Test.Domain
{
    using System.Collections.Generic;
    using EF6Test.Data;

    public class Vehicle
    {
        private readonly VehicleData data;

        private Vehicle(VehicleData data)
        {
            this.data = data;
        }

        public string RegistrationNumber
        {
            get => data.RegistrationNumber;
            set => data.RegistrationNumber = value?.Trim();
        }

        public string Vin
        {
            get => data.Vin;
            set => data.Vin = value?.Trim();
        }

        public void AttachDrivers(IReadOnlyCollection<long> driverIds)
        {
            
        }

        public void DetachDrivers(IReadOnlyCollection<long> driverIds)
        {
            
        }
    }
}
