namespace AspNetCoreAuthorization
{
    using AspNetCoreAuthorization.Models;
    using Microsoft.EntityFrameworkCore;
    
    public class CustomDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("Custom");
        }

        public DbSet<User> Users { get; set; }
    }
}
