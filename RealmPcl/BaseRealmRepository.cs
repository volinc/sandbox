namespace SqlitePclLock
{
    using Realms;

    public abstract class BaseRealmRepository
    {
        protected Realm Connection => DbContext.CreateConnection();

        protected BaseDbContext DbContext { get; }

        protected BaseRealmRepository(BaseDbContext dbContext)
        {
            DbContext = dbContext;
        }

        protected virtual void DeleteAll()
        {
            //todo: Implement
        }
    }
}
