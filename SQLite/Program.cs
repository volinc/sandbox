using System;
using System.Collections.Generic;
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

            for (var i = 0; i < 100; i++)
                AddLocation();

            var orderLocations = ReadAll(new[]
            {
                new Gap {BeginIndex = 1, EndIndex = 50}
            });
        }

        private static void AddLocation()
        {
            using (var connection = new SQLiteConnection("driver.db"))
            {
                var random = new Random();
                var previousIndex = ReadMaxIndex(connection);
                connection.Insert(new OrderLocation
                {
                    Index = ++previousIndex,
                    Latitude = random.NextDouble(),
                    Longitude = random.NextDouble()
                });                
            }            
        }

        //private static int ReadPreviousIndex(SQLiteConnection connection)
        //    => !connection.Table<OrderLocation>().Any() ? 0 : connection.Table<OrderLocation>().Max(x => x.Index);

        private static int ReadMaxIndex(SQLiteConnection connection)
            => connection.Table<OrderLocation>().Max(x => (int?)x.Index) ?? 0;

        private static IReadOnlyList<OrderLocation> ReadAll(IEnumerable<Gap> gaps)
        {
            using (var connection = new SQLiteConnection("driver.db"))
            {
                var query = connection.Table<OrderLocation>().AsQueryable();
                query = gaps.Aggregate(query,
                    (current, gap) => current.Where(x => gap.BeginIndex <= x.Index && x.Index <= gap.EndIndex));

                var orderLocations = query.ToList();
                return orderLocations;
            }
        }

        public class Gap
        {
            public int BeginIndex { get; set; }

            public int EndIndex { get; set; }
        }
    }
}
