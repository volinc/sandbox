using Forms.Driving.Data;

namespace Forms.Driving.Domain.Entities
{
    public class Profile
    {
        private readonly AccountData data;

        private Profile(AccountData data)
        {
            this.data = data;            
        }

        public string Phone => data.Phone;

        public bool IsEmployer => data.Profile?.OwnEmployerId.HasValue ?? false;

        public string GivenNames => data.Profile?.GivenNames;

        public string FamilyName => data.Profile?.FamilyName;

        public string FullName => $"{FamilyName} {GivenNames}";

        public static class Map
        {
            public static Profile From(AccountData data) => data == null ? null : new Profile(data);
        }
    }
}
