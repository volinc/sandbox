namespace SqlitePclLock
{
    using SQLite;

    public abstract class BaseSQLiteRepository<T> where T : class, new()
    {
        protected BaseDbContext DbContext { get; }

        protected BaseSQLiteRepository(BaseDbContext dbContext)
        {
            this.DbContext = dbContext;
        }

        protected virtual SQLiteConnection CreateConnection() => DbContext.CreateConnection();

        public virtual void DeleteAll()
        {
            using (var connection = CreateConnection())
            {
                connection.DeleteAll<T>();
            }
        }
    }
}
