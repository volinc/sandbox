namespace SqlitePclLock
{
    using SQLite;

    public abstract class BaseSQLiteRepository<T> where T : class, new()
    {
        protected BaseDbContext DbContext { get; }
        
        protected BaseSQLiteRepository(BaseDbContext dbContext)
        {
            DbContext = dbContext;
        }

        protected virtual SQLiteConnection GetConnection()
        {
            var connection = DbContext.CreateConnection();                 
            connection.CreateTable<T>();
            return connection;
        }

        protected virtual void DeleteAll()
        {
            using (var connection = DbContext.CreateConnection())
            {                
                connection.DropTable<T>();
            }            
        }
    }
}
