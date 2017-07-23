namespace EF6Test
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using EF6Test.Data;

    [DbConfigurationType(typeof(CodeBaseDbConfiguration))]
    public class ApplicationDbContext : CommonDbContext
    {
        public ApplicationDbContext() : base("name=ef6test")
        {            
        }

        public DbSet<PersonData> Persons { get; set; }

        public DbSet<DriverData> Drivers { get; set; }

        public DbSet<PassengerData> Passengers { get; set; }

        public DbSet<VehicleData> Vehicles { get; set; }

        public DbSet<ShiftData> Shifts { get; set; }

        public DbSet<SuggestionData> Suggestions { get; set; }

        public DbSet<OrderData> Orders { get; set; }

        public DbSet<AggregatorOrderData> AggregatorOrders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PersonData>(builder =>
            {
                builder.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);                
            });

            modelBuilder.Entity<PassengerData>(builder =>
            {
                builder.HasRequired(x => x.Person).WithOptional();
            });

            modelBuilder.Entity<DriverData>(builder =>
            {
                builder.HasRequired(x => x.Person).WithOptional();
            });

            modelBuilder.Entity<VehicleData>(builder =>
            {
                builder.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
                builder.Property(x => x.RegistrationNumber).IsRequired();
                builder.Property(x => x.Vin).IsRequired();
            });

            modelBuilder.Entity<ShiftData>(builder =>
            {
                builder.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            });

            modelBuilder.Entity<OrderData>(builder =>
            {
                builder.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
                builder.HasOptional(x => x.AggregatorOrder).WithOptionalDependent();
                //builder.HasRequired(x => x.Passenger).WithMany().HasForeignKey(x => x.PassengerId);
                //builder.HasOptional(x => x.Shift).WithMany().HasForeignKey(x => x.ShiftId);
            });

            modelBuilder.Entity<SuggestionData>(builder =>
            {
                builder.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
                builder.HasRequired(x => x.Order).WithMany(x => x.Suggestions).HasForeignKey(x => x.OrderId);
            });
        }
    }
}