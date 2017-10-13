using System;

namespace Forms.Driving.Domain
{
    public class LocationEventArgs : EventArgs
    {
        public LocationEventArgs(GeoLocation geoLocation)
        {
            GeoLocation = geoLocation;
        }

        public GeoLocation GeoLocation { get; }
    }
}