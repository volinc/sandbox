namespace SQLite
{
    public class OrderLocation
    {
        [PrimaryKey]
        public int Index { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }
    }
}
