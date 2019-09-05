namespace SqlitePclLock
{
    using SQLite;

    public abstract class BaseSQLiteRepository<T> where T : class, new()
    {
        private readonly object _init = new object();
        private SQLiteConnection connection;

        private SQLiteConnection Connection
        {
            get
            {
                if (connection != null)
                    return connection;

                connection = DbContext.CreateConnection();

                return connection;
            }
        }

        protected virtual SQLiteConnection SharedConnection
        {
            get
            {
                lock (_init)
                {
                    Connection.CreateTable<T>();
                    return Connection;
                }
            }
        }

        protected BaseDbContext DbContext { get; }

        protected BaseSQLiteRepository(BaseDbContext dbContext)
        {
            DbContext = dbContext;
        }

        protected virtual void DeleteAll()
        {
            Connection.DropTable<T>();
        }
    }
}
