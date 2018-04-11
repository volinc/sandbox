using System;
using MongoDB.Bson;
using MongoDB.Driver.GeoJsonObjectModel;

namespace MongoDB
{
    public class OrderTrackPoint
    {
        public ObjectId Id { get; set; }

        public long OrderId { get; set; }

        public int Index { get; set; }

        public GeoJsonPoint<GeoJson2DGeographicCoordinates> Location { get; set; }      

        public DateTimeOffset Timestamp { get; set; }        
    }
}
