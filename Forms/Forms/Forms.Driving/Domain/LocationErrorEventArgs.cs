using System;

namespace Forms.Driving.Domain
{
    public class LocationErrorEventArgs : EventArgs
    {
        public LocationErrorEventArgs(LocationError error)
        {
            Error = error; 
        }

        public LocationError Error { get; }
    }
}