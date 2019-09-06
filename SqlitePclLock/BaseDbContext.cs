namespace SqlitePclLock
{
    using SQLite;
    using System.IO;

    public abstract class BaseDbContext
    {
        private readonly static object sync = new object();

        public BaseDbContext(string fileName)
        {
            DatabasePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);
        }

        public string DatabasePath { get; }

        private SQLiteConnection connection;
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

                    //var openFlags = SQLiteOpenFlags.Create | SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.FullMutex | SQLiteOpenFlags.SharedCache;
                    //connection = new SQLiteConnection(DatabasePath, openFlags);
                    connection = new SQLiteConnection(DatabasePath);
                    CreateSchema(connection);
                    return connection;
                }
            }
        }

        protected abstract void CreateSchema(SQLiteConnection connection);
    }
}
