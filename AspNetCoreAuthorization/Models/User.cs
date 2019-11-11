namespace AspNetCoreAuthorization.Models
{
    using System;

    public class User
    {
        public long Id { get; set; }

        public string Email { get; set; }
        
        public byte[] Password { get; set; }

        public string Name { get; set; }

        public string Role { get; set; }

        public DateTimeOffset BirthDate { get; set; }

        public DateTimeOffset CreatedAt { get; set; }
    }
}