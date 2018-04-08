namespace SQLite
{
    public class OrderLocation
    {
        [PrimaryKey]
        public int Index { get; set; }

        public double Latitude { get; set; }

        public double Longtitude { get; set; }
    }
}
