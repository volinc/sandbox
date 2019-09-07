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

        protected virtual SQLiteConnection CreateConnection() => dbContext.CreateConnection();

        public virtual void DeleteAll()
        {
            using (var connection = CreateConnection())
            {
                connection.DeleteAll<T>();
            }
        }
    }
}
