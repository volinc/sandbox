namespace Forms.Driving.Data
{
    public class VehicleWriteData
    {
        public string RegistrationNumber { get; set; }

        public VehicleModelData Model { get; set; }

        public DirectoryItem Body { get; set; }

        public DirectoryItem Color { get; set; }                             
        
        public long? ManufactureYear { get; set; }        

        public string DraftLicenseNumber { get; set; }                       
    }
}