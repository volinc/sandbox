namespace SqlitePclLock
{
    using SQLite;
    using System.IO;

    public class BaseDbContext
    {
        private readonly object sync = new object();

        public BaseDbContext(string fileName)
        {
            DatabasePath = Path.Combine("./", fileName);
        }

        public string DatabasePath { get; }

        public SQLiteConnection CreateConnection() 
        {
            return new SQLiteConnection(DatabasePath);                            
        }
    }
}
