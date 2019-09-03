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
                
        public new void DeleteAll() => base.DeleteAll();

        public OrderLocation Create(long orderId, Location location, DateTimeOffset timestamp, double speed, double heading)
        {                       
            using (var connection = GetConnection())
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
            using (var connection = GetConnection())
            {
                var dataset = connection.Table<OrderLocationSqLite>()
                                        .OrderBy(x => x.Index)
                                        .ToArray();

                return dataset.Select(x => x.ToOrderTrackPoint())
                              .ToArray();
            }        
        }

        public int? ReadMaxIndexOrNull()
        {
            using (var connection = GetConnection())
            {
                var lastLocation = connection.Table<OrderLocationSqLite>()
                                             .OrderByDescending(x => x.Index)
                                             .FirstOrDefault();

                return lastLocation?.Index;
            }        
        }

        public IReadOnlyList<OrderTrackPoint> ReadAllInGaps(IReadOnlyCollection<OrderTrackGap> gaps)
        {            
            using (var connection = GetConnection())
            {
                var locations = connection.Table<OrderLocationSqLite>()
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

    public class OrderLocationRepositoryMultiThread : BaseSQLiteRepository<OrderLocationSqLite>
    {
        private readonly object _sync = new object();
        public OrderLocationRepositoryMultiThread(OrderDbContext dbContext) : base(dbContext)
        {
        }

        public new void DeleteAll()
        {
            lock (_sync)
            {
                base.DeleteAll();
            }
        }

        public OrderLocation Create(long orderId, Location location, DateTimeOffset timestamp, double speed, double heading)
        {
            lock (_sync)
            {
                using (var connection = GetConnection())
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
        }

        public IReadOnlyCollection<OrderTrackPoint> ReadAll()
        {
            lock (_sync)
            {
                using (var connection = GetConnection())
                {
                    var dataset = connection.Table<OrderLocationSqLite>()
                        .OrderBy(x => x.Index)
                        .ToArray();

                    return dataset.Select(x => x.ToOrderTrackPoint())
                        .ToArray();
                }
            }
        }

        public int? ReadMaxIndexOrNull()
        {
            lock (_sync)
            {
                using (var connection = GetConnection())
                {
                    var lastLocation = connection.Table<OrderLocationSqLite>()
                        .OrderByDescending(x => x.Index)
                        .FirstOrDefault();

                    return lastLocation?.Index;
                }
            }
        }

        public IReadOnlyList<OrderTrackPoint> ReadAllInGaps(IReadOnlyCollection<OrderTrackGap> gaps)
        {
            lock (_sync)
            {
                using (var connection = GetConnection())
                {
                    var locations = connection.Table<OrderLocationSqLite>()
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
    }
}
