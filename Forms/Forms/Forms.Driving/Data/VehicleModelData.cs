namespace Forms.Driving.Data
{
    public class VehicleModelData : DirectoryItem
    {    
        public string FullName { get; set; }
        
        public DirectoryItem Brand { get; set; }
        
        public DirectoryItem Class { get; set; }        
    }
}