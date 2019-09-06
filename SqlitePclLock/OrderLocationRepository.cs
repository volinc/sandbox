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
            try
            {
                Connection.BeginTransaction();
                var map = Connection.GetMapping<OrderLocationSqLite>();
                Connection.DeleteAll(map);
                Connection.Execute($"DELETE FROM sqlite_sequence WHERE name = '{map.TableName}';");
                Connection.Commit();
            }
            catch
            {
                Connection.Rollback();
            }
        }

        public OrderLocation Create(long orderId, Location location, DateTimeOffset timestamp, double speed, double heading)
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

            Connection.Insert(data);

            return data.ToOrderLocation();
        }

        public IReadOnlyCollection<OrderTrackPoint> ReadAll()
        {
            var set = Connection.Table<OrderLocationSqLite>()
                                .OrderBy(x => x.Index)
                                .ToArray();

            return set.Select(x => x.ToOrderTrackPoint())
                      .ToArray();
        }

        public int? ReadMaxIndexOrNull()
        {
            return Connection.Table<OrderLocationSqLite>()
                             .Max(x => (int?)x.Index)
                             .GetValueOrDefault();
        }

        public IReadOnlyList<OrderTrackPoint> ReadAllInGaps(IReadOnlyCollection<OrderTrackGap> gaps)
        {
            var set = Connection.Table<OrderLocationSqLite>()
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
