namespace SqlitePclLock
{
    using Taxys.Geometry;
    using System;
    using System.Collections.Generic;

    public class Position : IEquatable<Position>
    {
        public Position(Location location,
                        DateTimeOffset timestamp,
                        double speed,
                        double heading)
        {
            Location = location;
            Timestamp = timestamp;
            Speed = speed;
            Heading = heading;
        }

        public Location Location { get; }

        public DateTimeOffset Timestamp { get; }

        public double Speed { get; }

        public double Heading { get; }

        public override bool Equals(object obj) => Equals(obj as Position);

        public bool Equals(Position other)
        {
            if (other == null)
                return false;

            if (ReferenceEquals(this, other))
                return true;

            return Location.Equals(other.Location) && Timestamp.Equals(other.Timestamp);
        }

        public override int GetHashCode()
        {
            var hashCode = 2069189753;
            hashCode = hashCode * -1521134295 + EqualityComparer<Location>.Default.GetHashCode(Location);
            hashCode = hashCode * -1521134295 + EqualityComparer<DateTimeOffset>.Default.GetHashCode(Timestamp);
            return hashCode;
        }
    }

}
