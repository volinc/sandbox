namespace Taxys.Security.Confirmation
{
    using System;
    using System.Threading.Tasks;
    using Taxys.Security.Services;

    /// <summary>
    /// Генерирует и сохраняет в кэше уведомления, проверяет их наличие и удаляет из кэша.
    /// </summary>
    public class ConfirmationService
    {
        private readonly ICache cache;
        private readonly CodeGeneratorService codeGeneratorService;
        private readonly Func<DateTimeOffset> now;

        public ConfirmationService(ICache cache, 
                                   CodeGeneratorService codeGeneratorService,
                                   Func<DateTimeOffset> now,
                                   TimeSpan smsRetryInterval,
                                   TimeSpan mailRetryInterval,
                                   TimeSpan smsLifetime, 
                                   TimeSpan mailLifetime)
        {
            this.cache = cache;
            this.codeGeneratorService = codeGeneratorService;
            this.now = now;

            SmsRetryInterval = smsRetryInterval;
            MailRetryInterval = mailRetryInterval;
            SmsLifetime = smsLifetime;
            MailLifetime = mailLifetime;
        }                
        
        public TimeSpan SmsRetryInterval { get; }

        public TimeSpan MailRetryInterval { get; }

        public TimeSpan SmsLifetime { get; }

        public TimeSpan MailLifetime { get; }

        /// <summary>
        /// Создает подтверждение номера телефона и сохраняет его в хранилище.
        /// </summary>
        /// <param name="phone">Номер телефона.</param>
        /// <param name="codeType">Тип кода (регистрация, восстановление, и т.д.)</param>
        /// <returns>Подтверждение.</returns>
        public async Task<Confirmation> AddPhoneConfirmationAsync(string phone, string codeType)
        {            
            var code = codeGeneratorService.GeneratePhoneCode();
            phone = phone.Trim();
            var key = MakePhoneKey(phone, codeType);
            
            await ThrowIfAlreadySent(key, SmsRetryInterval);

            var confirmation = Confirmation.CreatePhone(phone, code, now());
            await cache.AddOrUpdateAsync(key, confirmation, SmsLifetime);
            return confirmation;
        }
        
        /// <summary>
        /// Создает подтверждение номера телефона с дополнительными данными и сохраняет его
        /// в хранилище.
        /// </summary>
        /// <param name="phone">Номер телефона.</param>
        /// <param name="payload">Дополнительные данные.</param>
        /// <param name="codeType">Тип кода (регистрация, восстановление, и т.д.)</param>
        /// <returns>Подтверждение.</returns>
        public async Task<Confirmation<T>> AddPhoneConfirmationAsync<T>(string phone, T payload, string codeType)
        {
            var code = codeGeneratorService.GeneratePhoneCode();
            phone = phone.Trim();
            var key = MakePhoneKey(phone, codeType);

            await ThrowIfAlreadySent(key, SmsRetryInterval);

            var confirmation = Confirmation<T>.CreatePhone(phone, code, now(), payload);            
            await cache.AddOrUpdateAsync(key, confirmation, SmsLifetime);
            return confirmation;            
        }

        /// <summary>
        /// Возвращает подтверждение и удаляет его из хранилища.
        /// </summary>
        /// <param name="phone">Номер телефона.</param>
        /// <param name="code">Код подтверждения.</param>
        /// <param name="codeType">Тип кода (регистрация, восстановление, и т.д.)</param>
        /// <returns>Полезная нагрузка подтвержения.</returns>
        public async Task<Confirmation> GetAndRemovePhoneConfirmationAsync(string phone, string code, string codeType)
        {
            var key = MakePhoneKey(phone, codeType);
            var conditional = await cache.TryRemoveAsync<Confirmation>(key);

            return !conditional.HasValue || !code.Equals(conditional.Value.Code)
                ? throw new InvalidOperationException("Confirmation is not found.")
                : conditional.Value;
        }

        /// <summary>
        /// Возвращает подтверждение.
        /// </summary>
        /// <param name="phone">Номер телефона.</param>
        /// <param name="code">Код подтверждения.</param>
        /// <param name="codeType">Тип кода (регистрация, восстановление, и т.д.)</param>
        /// <returns>Полезная нагрузка подтвержения.</returns>
        public async Task<Confirmation> GetPhoneConfirmationAsync(string phone, string code, string codeType)
        {
            var key = MakePhoneKey(phone, codeType);
            var conditional = await cache.TryGetValueAsync<Confirmation>(key);

            return !conditional.HasValue || !code.Equals(conditional.Value.Code)
                ? throw new InvalidOperationException("Confirmation is not found.")
                : conditional.Value;
        }

        /// <summary>
        /// Возвращает подтверждение c дополнительными данными и удаляет его из хранилища.
        /// </summary>
        /// <param name="phone">Номер телефона.</param>
        /// <param name="code">Код подтверждения.</param>
        /// <param name="codeType">Тип кода (регистрация, восстановление, и т.д.)</param>
        /// <returns>Полезная нагрузка подтвержения.</returns>        
        public async Task<Confirmation<T>> GetAndRemovePhoneConfirmationAsync<T>(string phone, string code, string codeType)
        {
            var key = MakePhoneKey(phone, codeType);
            var conditional = await cache.TryRemoveAsync<Confirmation<T>>(key);

            return !conditional.HasValue || !code.Equals(conditional.Value.Code)
                ? throw new InvalidOperationException("Confirmation is not found.")
                : conditional.Value;
        }

        /// <summary>
        /// Возвращает подтверждение c дополнительными данными.
        /// </summary>
        /// <param name="phone">Номер телефона.</param>
        /// <param name="code">Код подтверждения.</param>
        /// <param name="codeType">Тип кода (регистрация, восстановление, и т.д.)</param>
        /// <returns>Полезная нагрузка подтвержения.</returns>        
        public async Task<Confirmation<T>> GetPhoneConfirmationAsync<T>(string phone, string code, string codeType)
        {
            var key = MakePhoneKey(phone, codeType);
            var conditional = await cache.TryGetValueAsync<Confirmation<T>>(key);

            return !conditional.HasValue || !code.Equals(conditional.Value.Code)
                ? throw new InvalidOperationException("Confirmation is not found.")
                : conditional.Value;
        }

        private static string MakePhoneKey(string phone, string codeType) => codeType?.Trim() + phone?.Trim();

        /// <summary>
        /// Создает подтверждение E-mail адреса и сохраняет его в хранилище на указанное время.
        /// </summary>
        /// <param name="email">E-mail адрес.</param>
        /// <param name="codeType">Тип кода (регистрация, восстановление, и т.д.)</param>
        /// <returns>Подтверждение.</returns>
        public async Task<Confirmation> AddEmailConfirmationAsync(string email, string codeType)
        {
            var code = codeGeneratorService.GenerateEmailCode();
            email = email.Trim();
            var key = MakeEmailKey(code, codeType);

            await ThrowIfAlreadySent(key, MailRetryInterval);
            
            var confirmation = Confirmation.CreateEmail(email, code, now());
            await cache.AddOrUpdateAsync(key, confirmation, MailLifetime);
            return confirmation;            
        }

        /// <summary>
        /// Создает подтверждение E-mail адреса и сохраняет его в хранилище на указанное время.
        /// </summary>
        /// <param name="email">E-mail адрес.</param>
        /// <param name="payload">Дополнительные данные.</param>
        /// <param name="codeType">Тип кода (регистрация, восстановление, и т.д.)</param>
        /// <returns>Подтверждение.</returns>
        public async Task<Confirmation<T>> AddEmailConfirmationAsync<T>(string email, T payload, string codeType)
        {
            var code = codeGeneratorService.GenerateEmailCode();
            email = email.Trim();
            var key = MakeEmailKey(code, codeType);

            await ThrowIfAlreadySent(key, MailRetryInterval);
            
            var confirmation = Confirmation<T>.CreateEmail(email, code, now(), payload);
            await cache.AddOrUpdateAsync(key, confirmation, MailLifetime);
            return confirmation;
        }

        /// <summary>
        /// Возвращает подтверждение и удаляет его из хранилища.
        /// </summary>
        /// <param name="code">Код подтверждения.</param>
        /// <param name="codeType"></param>
        /// <returns>Полезная нагрузка подтвержения.</returns>
        public async Task<Confirmation<T>> GetAndRemoveEmailConfirmationAsync<T>(string code, string codeType)
        {
            var conditional = await cache.TryRemoveAsync<Confirmation<T>>(MakeEmailKey(code, codeType));

            return !conditional.HasValue || !code.Equals(conditional.Value.Code)
                ? throw new InvalidOperationException("Confirmation is not found.")
                : conditional.Value;
        }

        /// <summary>
        /// Возвращает подтверждение и удаляет его из хранилища.
        /// </summary>
        /// <param name="code">Код подтверждения.</param>
        /// <param name="codeType"></param>
        /// <returns>Полезная нагрузка подтвержения.</returns>
        public async Task<Confirmation> GetAndRemoveEmailConfirmationAsync(string code, string codeType)
        {
            var conditional = await cache.TryRemoveAsync<Confirmation>(MakeEmailKey(code, codeType));

            return !conditional.HasValue || !code.Equals(conditional.Value.Code)
                ? throw new InvalidOperationException("Confirmation is not found.")
                : conditional.Value;
        }
        
        protected async Task ThrowIfAlreadySent(string key, TimeSpan retryInterval)
        {
            var optional = await cache.TryGetValueAsync<Confirmation>(key);
            if (optional.TryGet(out var confirmation))
            {
                if (now() - confirmation.CreatedAt < retryInterval)
                    throw new InvalidOperationException("Confirmation is already sent.");
            }
        }

        private static string MakeEmailKey(string code, string codeType) => codeType?.Trim() + code?.Trim();
    }
}