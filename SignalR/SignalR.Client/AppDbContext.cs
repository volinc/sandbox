using Microsoft.EntityFrameworkCore;

namespace SignalR.Client
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Offer> Offers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {                
                optionsBuilder.UseInMemoryDatabase("testdb");                
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Offer>(builder =>
            {
                builder.Property(x => x.Id).ValueGeneratedNever();
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
