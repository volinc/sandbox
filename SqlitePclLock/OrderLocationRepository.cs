namespace SqlitePclLock
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Taxys.Geometry;

    public class OrderLocationRepository : BaseSQLiteRepository<OrderLocationSqLite>
    {
        private readonly object sync = new object();
        private int index = 0;

        public OrderLocationRepository(OrderDbContext dbContext) : base(dbContext)
        {
        }

        public new void DeleteAll()
        {
            lock (sync)
            {
                SharedConnection.DeleteAll<OrderLocationSqLite>();
                index = 0;
            }
        }

        public OrderLocation Create(long orderId, Location location, DateTimeOffset timestamp, double speed, double heading)
        {
            lock (sync)
            {
                var i = ReadMaxIndex() + 1;
                var data = new OrderLocationSqLite
                {
                    Index = i,
                    OrderId = orderId,
                    Latitude = location.Latitude,
                    Longitude = location.Longitude,
                    Timestamp = timestamp,
                    Speed = speed,
                    Heading = heading
                };

                SharedConnection.Insert(data);
                index = data.Index;

                return data.ToOrderLocation();
            }
        }

        public IReadOnlyCollection<OrderTrackPoint> ReadAll()
        {
            lock (sync)
            {
                var set = SharedConnection.Table<OrderLocationSqLite>()
                                          .OrderBy(x => x.Index)
                                          .ToArray();

                return set.Select(x => x.ToOrderTrackPoint())
                          .ToArray();
            }
        }

        public int? ReadMaxIndexOrNull()
        {
            lock (sync)
            {
                var value = ReadMaxIndex();
                return value == 0
                    ? (int?)null
                    : value;
            }
        }

        private int ReadMaxIndex()
        {
            if (index > 0)
                return index;

            var data = SharedConnection.Table<OrderLocationSqLite>()
                                       .LastOrDefault();

            return data != null ? data.Index : 0;
        }

        public IReadOnlyList<OrderTrackPoint> ReadAllInGaps(IReadOnlyCollection<OrderTrackGap> gaps)
        {
            lock (sync)
            {
                var set = SharedConnection.Table<OrderLocationSqLite>()
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
