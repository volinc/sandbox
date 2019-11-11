namespace Taxys.Security
{
    using System;
    using System.Linq;
    using Jose;
    using Microsoft.AspNetCore.Authentication.JwtBearer;
    using Microsoft.Extensions.Caching.Distributed;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.DependencyInjection.Extensions;
    using Taxys.Security.Confirmation;
    using Taxys.Security.Services;

    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddTaxysAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            services.AddAuthentication(options =>
            {
                options.AddScheme<CustomAuthHandler>(JwtBearerDefaults.AuthenticationScheme, JwtBearerDefaults.AuthenticationScheme);
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            });

            services.AddSecurity(configuration);

            return services;
        }
        
        private static IServiceCollection AddSecurity(this IServiceCollection services, IConfiguration configuration)
        {                        
            var hex = configuration.GetValue<string>("TOKEN_PASSWORD");            

            services.TryAddSingleton(sp => new SecurityConfiguration
            {
                SigningAlgorithm = configuration.GetValue("SIGNING_ALGORITHM", nameof(JweAlgorithm.A128GCMKW)),
                EncryptingAlgorithm = configuration.GetValue("ENCRYPTING_ALGORITHM", nameof(JweEncryption.A128CBC_HS256)),
                TokenPassword = StringToByteArray(hex)
            });

            services.TryAddSingleton<TokenCryptoService>();

            //services.AddDistributedMemoryCache();

            services.RemoveAll<IDistributedCache>();
            services.AddStackExchangeRedisCache(options =>
            {
                var connectionString = configuration.GetValue<string>("REDISCACHE_CONNSTR");
                options.Configuration = connectionString;
            });            

            services.TryAddSingleton(sp =>
            {
                var now = sp.GetRequiredService<Func<DateTimeOffset>>();
                var tokenCryptoService = sp.GetRequiredService<TokenCryptoService>();
                var cache = sp.GetRequiredService<IDistributedCache>();
                
                var accessTokenLifetime = configuration.GetValue("ACCESS_TOKEN_LIFETIME", TimeSpan.FromHours(1));
                var refreshTokenLifetime = configuration.GetValue("REFRESH_TOKEN_LIFETIME", TimeSpan.FromDays(90));
                
                return new AuthenticationService(now, tokenCryptoService, cache, accessTokenLifetime, refreshTokenLifetime);
            });

            services.TryAddSingleton<CodeGeneratorService>();

            services.TryAddSingleton(sp =>
            {
                var cache = sp.GetRequiredService<ICache>();
                var codeGeneratorService = sp.GetRequiredService<CodeGeneratorService>();
                var now = sp.GetRequiredService<Func<DateTimeOffset>>();

                var smsRetryInterval = configuration.GetValue("SMS_RETRY_INTERVAL", TimeSpan.FromSeconds(90));
                var emailRetryInterval = configuration.GetValue("MAIL_RETRY_INTERVAL", TimeSpan.FromSeconds(30));
                
                var smsLifetime = configuration.GetValue("SMS_CONFIRMATION_LIFETIME", TimeSpan.FromMinutes(5));
                var emailLifetime = configuration.GetValue("MAIL_CONFIRMATION_LIFETIME", TimeSpan.FromHours(8));

                return new ConfirmationService(cache, codeGeneratorService, now, smsRetryInterval, emailRetryInterval, smsLifetime, emailLifetime);
            });

            services.TryAddSingleton<ICache, AzureRedisCache>();

            return services;
        }

        internal static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }
    }
}
