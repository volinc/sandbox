namespace SqlitePclLock
{
    using SQLite;
    using System.IO;

    public abstract class BaseDbContext
    {
        private readonly object sync = new object();
        private bool isInitialized;

        public BaseDbContext(string fileName)
        {
            DatabasePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);
        }

        public string DatabasePath { get; }
        
        public virtual SQLiteConnection CreateConnection()
        {
            lock (sync)
            {                                
                var connection = new SQLiteConnection(DatabasePath);
                if (!isInitialized)
                {
                    CreateSchema(connection);
                    isInitialized = true;
                }
                return connection;
            }
        }

        protected abstract void CreateSchema(SQLiteConnection connection);
    }
}
