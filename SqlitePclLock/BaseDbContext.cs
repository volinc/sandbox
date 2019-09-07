namespace SqlitePclLock
{
    using SQLite;
    using System.IO;

    public abstract class BaseDbContext
    {
        private readonly object sync = new object();

        public BaseDbContext(string fileName)
        {
            DatabasePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);
        }

        public string DatabasePath { get; }

        private SQLiteConnection connection;
        private bool isInitialized;
        public virtual SQLiteConnection Connection
        {
            get
            {
                //if (connection != null)
                //    return connection;

                lock (sync)
                {
                    if (connection != null)
                        return connection;

                    connection = new SQLiteConnection(DatabasePath);
                    if (!isInitialized)
                    {
                        CreateSchema(connection);
                        isInitialized = true;
                    }
                    return connection;
                }
            }
        }

        protected abstract void CreateSchema(SQLiteConnection connection);
    }
}
