namespace SqlitePclLock
{
    using SQLite;
    using System.IO;

    public class BaseDbContext
    {

        public BaseDbContext(string fileName)
        {
            DatabasePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);
        }

        public string DatabasePath { get; }

        public SQLiteConnection CreateConnection()
        {
            return new SQLiteConnection(DatabasePath, SQLiteOpenFlags.Create
                                                      | SQLiteOpenFlags.ReadWrite
                                                      | SQLiteOpenFlags.FullMutex
                                                      | SQLiteOpenFlags.SharedCache);
        }
    }
}
