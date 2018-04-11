using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace MongoDB
{
    public class OrderTrackPointRepository
    {
        private const string DatabaseName = "dispatcher";
        private const string CollectionName = "orderTracks";

        private readonly MongoClient mongoClient;

        static OrderTrackPointRepository()
        {
            BsonClassMap.RegisterClassMap<OrderTrackPoint>();
        }

        public OrderTrackPointRepository(string connectionString)
        {
            var settings = MongoClientSettings.FromUrl(new MongoUrl(connectionString));
            mongoClient = new MongoClient(settings);

            var database = mongoClient.GetDatabase(DatabaseName);
            var points = database.GetCollection<OrderTrackPoint>(CollectionName);

            var indexKeys = Builders<OrderTrackPoint>.IndexKeys.Combine(
                Builders<OrderTrackPoint>.IndexKeys.Ascending(x => x.OrderId),
                Builders<OrderTrackPoint>.IndexKeys.Ascending(x => x.Index));

            points.Indexes.CreateOne(indexKeys,
                new CreateIndexOptions {Unique = true, Name = "IX_OrderId_Index"});
        }

        public async void CreateAsync(long orderId, int index, Location location, DateTimeOffset timestamp)
        {
            var database = mongoClient.GetDatabase(DatabaseName);
            var points = database.GetCollection<OrderTrackPoint>(CollectionName);

            await points.WithWriteConcern(WriteConcern.Unacknowledged).InsertOneAsync(new OrderTrackPoint
            {
                OrderId = orderId,
                Index = index,
                Location = location.ToGeoJsonPoint(),
                Timestamp = timestamp
            });
        }

        public OrderTrackPoint ReadLastByOrderId(long orderId)
        {
            var database = mongoClient.GetDatabase(DatabaseName);
            var points = database.GetCollection<OrderTrackPoint>(CollectionName);

            return points.AsQueryable()
                .Where(x => x.OrderId == orderId)
                .OrderByDescending(x => x.Index)
                .FirstOrDefault();
        }

        public IReadOnlyList<OrderTrackPoint> ReadAllByOrderId(long orderId)
        {
            var database = mongoClient.GetDatabase(DatabaseName);
            var points = database.GetCollection<OrderTrackPoint>(CollectionName);

            return points.AsQueryable()
                .Where(x => x.OrderId == orderId)
                .ToArray();
        }

        public void DeleteByOrderId(long orderId)
        {
            var database = mongoClient.GetDatabase(DatabaseName);
            var points = database.GetCollection<OrderTrackPoint>(CollectionName);

            points.DeleteMany(x => x.OrderId == orderId);
        }
    }
}