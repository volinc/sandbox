using System.Text.RegularExpressions;
using Forms.Driving.Data;
using Forms.Driving.Extensions;

namespace Forms.Driving.Domain.Entities
{
    public class Vehicle
    {
        private readonly VehicleData data;

        private Vehicle()
        {
            data = new VehicleData
            {                
                Model = new VehicleModelData
                {
                    Brand = new DirectoryItem { Name = string.Empty },
                    Class = new DirectoryItem { Name = string.Empty },
                },
                Color = new DirectoryItem { Name = string.Empty },
                Body = new DirectoryItem { Name = string.Empty }
            };
        }

        internal Vehicle(string registrationNumber) : this()
        {
            registrationNumber.ThrowIfNullOrWhitespace(nameof(RegistrationNumber));

            data.RegistrationNumber = FormatRegistrationNumber(registrationNumber);
        }

        private Vehicle(VehicleData data)
        {
            this.data = data;
        }

        public long Id => data.Id;

        public bool IsOwn => !data.EmployerId.HasValue;

        public string ClassName => data.Model?.Class?.Name;
        
        public DirectoryItem Brand
        {
            get => data.Model?.Brand;
            set
            {
                if (data.Model == null)
                    data.Model = new VehicleModelData();

                data.Model.Brand = value;
            }
        }

        public DirectoryItem Model
        {
            get => data.Model;
            set => data.Model = value as VehicleModelData;
        }

        public DirectoryItem Color
        {
            get => data.Color;
            set => data.Color = value;
        }
        
        public DirectoryItem Body
        {
            get => data.Body;
            set => data.Body = value;
        }

        public string RegistrationNumber => data.RegistrationNumber;

        public long? ManufactureYear
        {
            get => data.ManufactureYear;
            set => data.ManufactureYear = value;
        }
        
        public static string FormatRegistrationNumber(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return null;

            var regex = new Regex(@"\W");

            return regex.Replace(value, string.Empty)
                        .ToLowerInvariant();
        }

        public string ItemName => ToString();

        public override string ToString() => $"{Color.Name} {Model.Name} {RegistrationNumber}";

        public static class Map
        {
            public static Vehicle From(VehicleData data) => data == null ? null : new Vehicle(data);

            public static VehicleData To(Vehicle domain) => domain?.data;
        }
    }
}