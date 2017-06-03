namespace EF6Test.Data
{
    using System;

    public class PassengerData
    {
        public long Id { get; set; }

        public DateTimeOffset BirthDate { get; set; }

        public virtual PersonData Person { get; set; }
    }
}