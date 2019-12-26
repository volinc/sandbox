namespace Taxys.Security.Confirmation
{
    using System;
    using Newtonsoft.Json;

    public class Confirmation
    {
        [JsonConstructor]
        protected Confirmation(string phone, string email, string code, DateTimeOffset createdAt)
        {
            Phone = phone;
            Email = email;
            Code = code;
            CreatedAt = createdAt;
        }

        public static Confirmation CreatePhone(string phone, string code, DateTimeOffset createdAt)
        {
            return new Confirmation(phone, null, code, createdAt);
        }

        public static Confirmation CreateEmail(string email, string code, DateTimeOffset createdAt)
        {
            return new Confirmation(null, email, code, createdAt);
        }

        public string Phone { get; }

        public string Email { get; }

        public string Code { get; }

        public DateTimeOffset CreatedAt { get; }
    }

    public class Confirmation<T> : Confirmation
    {
        [JsonConstructor]
        protected Confirmation(string phone, string email, string code, DateTimeOffset createdAt, T payload) 
            : base(phone, email, code, createdAt)
        {
            Payload = payload;
        }

        public static Confirmation<T> CreatePhone(string phone, string code, DateTimeOffset createdAt, T payload)
        {
            return new Confirmation<T>(phone, null, code, createdAt, payload);
        }

        public static Confirmation<T> CreateEmail(string email, string code, DateTimeOffset createdAt, T payload)
        {
            return new Confirmation<T>(null, email, code, createdAt, payload);
        }

        public T Payload { get; }        
    }
}