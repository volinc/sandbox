using System.Collections.Generic;

namespace Forms.Driving.Data
{
    public class ShiftData
    {
        public long Id { get; set; }
        
        public VehicleModelData VehicleModel { get; set; }
        
        public string VehicleRegistrationNumber { get; set; }

        public string LicenseNumber { get; set; }
        
        public DirectoryItem VehicleColor { get; set; }
        
        public DirectoryItem VehicleBody { get; set; }
        
        public IReadOnlyCollection<DirectoryItem> VehicleClasses { get; set; }
        
        public DirectoryItem State { get; set; }
        
        public string EmployerCompanyName { get; set; }        
    }
}
