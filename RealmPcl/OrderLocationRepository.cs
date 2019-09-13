namespace SqlitePclLock
{
    using Taxys.Geometry;
    using Realms;
    using System.Linq;
    using System;
    using System.Collections.Generic;

    public class LocationCounter : RealmObject
    {
        [PrimaryKey]
        public int Id { get; set; }

        public RealmInteger<int> Counter { get; set; }
    }

    public class OrderLocationRepository : BaseRealmRepository
    {
        public OrderLocationRepository(BaseDbContext dbContext)
            : base(dbContext)
        {

        }

        public void Create(long orderId, Location location, DateTimeOffset timestamp, double speed, double heading)
        {
            var data = new OrderLocationRealm
            {
                OrderId = orderId,
                Latitude = location.Latitude,
                Longitude = location.Longitude,
                Timestamp = timestamp,
                Speed = speed,
                Heading = heading
            };

            using (var realm = Connection)
            {
                realm.Refresh();
                using (var transaction = Connection.BeginWrite())
                {
                    var counter = realm.Find<LocationCounter>(1);
                    if (counter == null)
                    {
                        realm.Add(new LocationCounter
                        {
                            Id = 1,
                        });
                        counter = realm.Find<LocationCounter>(1);
                    }

                    counter.Counter.Increment();
                    data.Index = counter.Counter;

                    realm.Add(data);

                    transaction.Commit();
                }
            }
        }

        public IReadOnlyCollection<OrderTrackPoint> ReadAll()
        {
            using (var conn = Connection)
            {
                conn.Refresh();

                return conn.All<OrderLocationRealm>()
                           .OrderBy(x => x.Index)
                           .AsEnumerable()
                           .Select(x => x.ToOrderTrackPoint())
                           .ToArray();
            }
        }

        public int? ReadMaxIndexOrNull()
        {
            using (var conn = Connection)
            {
                conn.Refresh();

                return conn.All<OrderLocationRealm>()
                           .OrderBy(x => x.Index)                           
                           .LastOrDefault()
                           ?.Index;
            }
        }

        public new void DeleteAll()
        {
            using (var conn = Connection)
            {
                using (var transaction = conn.BeginWrite())
                {
                    conn.Refresh();

                    conn.RemoveAll<OrderLocationRealm>();
                    conn.RemoveAll<LocationCounter>();

                    transaction.Commit();
                }
            }
        }
    }
}
