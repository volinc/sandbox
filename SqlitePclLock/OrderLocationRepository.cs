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

        public new void DeleteAll()
        {
            SharedConnection.Execute("DELETE FROM sqlite_sequence WHERE name = 'OrderLocationSqLite';");
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

            SharedConnection.Insert(data);

            return data.ToOrderLocation();
        }


        public IReadOnlyCollection<OrderTrackPoint> ReadAll()
        {
            var set = SharedConnection.Table<OrderLocationSqLite>()
                                    .OrderBy(x => x.Index)
                                    .ToArray();

            return set.Select(x => x.ToOrderTrackPoint())
                          .ToArray();
        }

        public int? ReadMaxIndexOrNull()
        {
            var lastLocation = SharedConnection.Table<OrderLocationSqLite>()
                                         .OrderByDescending(x => x.Index)
                                         .FirstOrDefault();

            return lastLocation?.Index;
        }

        public IReadOnlyList<OrderTrackPoint> ReadAllInGaps(IReadOnlyCollection<OrderTrackGap> gaps)
        {
            var locations = SharedConnection.Table<OrderLocationSqLite>()
                                      .ToArray();

            var allInGaps = new List<OrderLocationSqLite>();
            foreach (var gap in gaps)
            {
                var allInGap = locations.Where(x => gap.BeginIndex <= x.Index && x.Index <= gap.EndIndex);
                allInGaps.AddRange(allInGap);
            }

            return allInGaps.Select(x => x.ToOrderTrackPoint())
                            .ToArray();
        }
    }
}
