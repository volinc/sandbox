namespace SqlitePclLock
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Taxys.Geometry;

    public class OrderLocationRepository : BaseSQLiteRepository<OrderLocationSqLite>
    {
        public OrderLocationRepository(OrderDbContext dbContext) : base(dbContext)
        {
        }

        public override void DeleteAll()
        {
            using (var connection = CreateConnection())
            {
                try
                {
                    connection.BeginTransaction();
                    var map = connection.GetMapping<OrderLocationSqLite>();
                    connection.DeleteAll(map);
                    connection.Execute($"DELETE FROM sqlite_sequence WHERE name = '{map.TableName}';");
                    connection.Commit();
                }
                catch
                {
                    connection.Rollback();
                }
            }
        }

        public OrderLocation Create(long orderId, Location location, DateTimeOffset timestamp, double speed, double heading)
        {
            using (var connection = CreateConnection())
            {
                var data = new OrderLocationSqLite
                {
                    OrderId = orderId,
                    Latitude = location.Latitude,
                    Longitude = location.Longitude,
                    Timestamp = timestamp,
                    Speed = speed,
                    Heading = heading
                };

                connection.Insert(data);

                return data.ToOrderLocation();
            }
        }

        public IReadOnlyCollection<OrderTrackPoint> ReadAll()
        {
            using (var connection = CreateConnection())
            {
                var set = connection.Table<OrderLocationSqLite>()
                                    .OrderBy(x => x.Index)
                                    .ToArray();

                return set.Select(x => x.ToOrderTrackPoint())
                          .ToArray();
            }
        }

        public int? ReadMaxIndexOrNull()
        {
            using (var connection = CreateConnection())
            {
                return connection.Table<OrderLocationSqLite>()
                                 .Max(x => (int?)x.Index)
                                 .GetValueOrDefault();
            }
        }

        public IReadOnlyList<OrderTrackPoint> ReadAllInGaps(IReadOnlyCollection<OrderTrackGap> gaps)
        {
            using (var connection = CreateConnection())
            {
                var set = connection.Table<OrderLocationSqLite>()
                                    .ToArray();

                var allInGaps = new List<OrderLocationSqLite>();
                foreach (var gap in gaps)
                {
                    var allInGap = set.Where(x => gap.BeginIndex <= x.Index && x.Index <= gap.EndIndex);
                    allInGaps.AddRange(allInGap);
                }

                return allInGaps.Select(x => x.ToOrderTrackPoint())
                                .ToArray();
            }
        }
    }
}
