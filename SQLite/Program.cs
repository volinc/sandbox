using System;
using System.Linq;

namespace SQLite
{
    internal class Program
    {
        private static void Main()
        {
            var connection = new SQLiteConnection("driver.db");
            connection.CreateTable<OrderLocation>();
            connection.CreateTable<LogEvent>();

            var orderLocation = AddLocation();
        }

        private static OrderLocation AddLocation()
        {
            var connection = new SQLiteConnection("driver.db");
            var random = new Random();
            var previousIndex = connection.Table<OrderLocation>().Max(x => x.Index);
            connection.Insert(new OrderLocation
            {
                Index = ++previousIndex,
                Latitude = random.NextDouble(),
                Longtitude = random.NextDouble()
            });
            return connection.Table<OrderLocation>().SingleOrDefault(x => x.Index == previousIndex);
        }
    }
}
