using System;
using MongoDB.Driver.GeoJsonObjectModel;

namespace MongoDB
{
    public static class LocationExtensions
    {
        public static GeoJsonPoint<GeoJson2DGeographicCoordinates> ToGeoJsonPoint(this Location location)
        {
            if (location == null)
                throw new ArgumentNullException(nameof(location));

            return GeoJson.Point(new GeoJson2DGeographicCoordinates(location.Longitude, location.Latitude));
        }
    }
}
