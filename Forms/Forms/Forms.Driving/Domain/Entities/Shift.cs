using System;
using System.Collections.Generic;
using System.Linq;
using Forms.Driving.Data;

namespace Forms.Driving.Domain.Entities
{
    public class Shift
    {
        private readonly ShiftData data;

        private Shift(ShiftData data)
        {
            this.data = data;
        }

        public long Id => data.Id;

        public string EmployerCompanyName => data.EmployerCompanyName;

        public string FullModelName => data.VehicleModel.FullName;

        public string RegistrationNumber => data.VehicleRegistrationNumber;

        public string LicenseNumber => data.LicenseNumber;

        public string ColorName => data.VehicleColor.Name;

        public string BodyName => data.VehicleBody.Name;

        public IReadOnlyCollection<string> Classes => data.VehicleClasses.Select(x => x.Name).ToList();

        public ShiftState State => (ShiftState)data.State.Id;

        public string Description => $"{ColorName} {FullModelName} {RegistrationNumber}";
        
        public string ExtraDescription => $"{LicenseNumber}".Trim() +
                                          $"{Environment.NewLine}{string.Join(", ", Classes)}".Trim() +
                                          $"{Environment.NewLine}{EmployerCompanyName}".Trim();

        public void Busy()
        {
            data.State = new DirectoryItem {Id = (long) ShiftState.Busy, Name = "Занята"};
        }

        public void Available()
        {
            data.State = new DirectoryItem {Id = (long) ShiftState.Available, Name = "Доступна"};
        }

        public static class Map
        {
            public static Shift From(ShiftData data) => data == null ? null : new Shift(data);
        }        
    }
}