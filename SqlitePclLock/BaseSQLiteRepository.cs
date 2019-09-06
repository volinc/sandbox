namespace SqlitePclLock
{
    using SQLite;

    public abstract class BaseSQLiteRepository<T> where T : class, new()
    {
        private readonly BaseDbContext dbContext;

        protected BaseSQLiteRepository(BaseDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        protected virtual SQLiteConnection Connection => dbContext.Connection;

        public virtual void DeleteAll() => Connection.DeleteAll<T>();
    }
}
