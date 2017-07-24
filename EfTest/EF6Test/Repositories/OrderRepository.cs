namespace EF6Test.Repositories
{
    using System;

    public class OrderRepository
    {
        private readonly ApplicationDbContext dbContext;

        public OrderRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Guid suggestionId)
        {
            
        }
    }
}
