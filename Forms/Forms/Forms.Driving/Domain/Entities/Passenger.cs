using Forms.Driving.Data;

namespace Forms.Driving.Domain.Entities
{
    public class Passenger
    {
        private readonly PassengerData data;

        public Passenger(PassengerData data)
        {
            this.data = data;
        }

        public string ContactPhone => data.ContactPhone;

        internal static class Map
        {
            public static Passenger From(PassengerData data) => data == null ? null : new Passenger(data);

            public static PassengerData To(Passenger domain) => domain?.data;
        }
    }
}
