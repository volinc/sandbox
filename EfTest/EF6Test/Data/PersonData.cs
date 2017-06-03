namespace EF6Test.Data
{
    using System;

    public class PersonData
    {
        public long Id { get; set; }

        public string GivenNames { get; set; }

        public string FamilyName { get; set; }

        public DateTimeOffset CreatedAt { get; set; }
    }
}