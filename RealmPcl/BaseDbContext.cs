namespace SqlitePclLock
{
    using Realms;
    using System.IO;

    public class BaseDbContext
    {

        public BaseDbContext(string fileName)
        {
            DatabasePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);
        }

        public string DatabasePath { get; }

        public Realm CreateConnection()
        {
            var config = new RealmConfiguration(DatabasePath);
            var result = Realm.GetInstance(config);

            return result;
        }
    }
}
