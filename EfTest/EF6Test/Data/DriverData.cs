namespace EF6Test.Data
{
    using System.Collections.Generic;

    public class DriverData
    {
        public long Id { get; set; }

        public string LicenseNumber { get; set; }

        public int? ExperienceFrom { get; set; }

        public virtual PersonData Person { get; set; }

        public virtual ICollection<OrderData> Orders { get; } = new HashSet<OrderData>();
    }
}