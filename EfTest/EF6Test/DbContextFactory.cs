namespace EF6Test
{
    using System.Data.Entity.Infrastructure;
    using Autofac;

    public class DbContextFactory : IDbContextFactory<ApplicationDbContext>
    {
        private readonly ILifetimeScope lifetimeScope;

        public DbContextFactory(ILifetimeScope lifetimeScope)
        {
            this.lifetimeScope = lifetimeScope;
        }

        public ApplicationDbContext Create()
        {
            return lifetimeScope.Resolve<ApplicationDbContext>();
        }        
    }
}
