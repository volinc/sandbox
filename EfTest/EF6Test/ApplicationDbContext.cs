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

        public DbSet<OrderData> Orders { get; set; }

        public DbSet<SearchData> Searches { get; set; }

        public DbSet<SuggestionData> Suggestions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PersonData>(builder =>
            {
                builder.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            });

            modelBuilder.Entity<DriverData>(builder =>
            {
                builder.HasRequired(x => x.Person).WithOptional();                
            });            

            modelBuilder.Entity<PassengerData>(builder =>
            {
                builder.HasRequired(x => x.Person).WithOptional();
            });

            modelBuilder.Entity<OrderData>(builder =>
            {
                builder.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
                builder.HasRequired(x => x.Driver).WithMany(x => x.Orders).HasForeignKey(x => x.DriverId);
            });

            modelBuilder.Entity<SearchData>(builder =>
            {
                builder.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            });

            modelBuilder.Entity<SuggestionData>(builder =>
            {
                builder.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
                builder.HasRequired(x => x.Search).WithMany(x => x.Suggestions).HasForeignKey(x => x.SearchId);
            });
        }
    }
}