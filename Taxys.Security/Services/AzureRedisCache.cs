namespace Taxys.Security.Services
{
    using System;
    using System.Threading.Tasks;
    using Microsoft.Extensions.Caching.Distributed;
    using Microsoft.Extensions.Logging;
    using Taxys.Domain;
    
    public class AzureRedisCache : ICache
    {
        private readonly IDistributedCache distributedCache;
        private readonly ILogger<AzureRedisCache> logger;
        private readonly JsonSerializer jsonSerializer;

        public AzureRedisCache(IDistributedCache distributedCache, 
                               ILogger<AzureRedisCache> logger, 
                               JsonSerializer jsonSerializer)
        {
            this.distributedCache = distributedCache;
            this.logger = logger;
            this.jsonSerializer = jsonSerializer;
        }
        
        public async Task AddOrUpdateAsync<TValue>(string key, TValue value, TimeSpan? lifeTime = null)
        {            
            var json = jsonSerializer.Serialize(value);
            
            await distributedCache.SetStringAsync(key, json, new DistributedCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = lifeTime
            });
        }
        
        public async Task<bool> TryAddAsync<TValue>(string key, TValue value, TimeSpan? lifeTime = null)
        {
            try
            {
                var json = await distributedCache.GetStringAsync(key);
                if (json != null)
                    return false;

                json = jsonSerializer.Serialize(value);
                
                await distributedCache.SetStringAsync(key, json, new DistributedCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow  = lifeTime
                });
                
                return true;
            }
            catch (Exception exception)
            {
                logger.LogError(exception, $"key={key} value={value} lifetime={lifeTime}");
                return false;
            }
        }
        
        public async Task<ConditionalValue<TValue>> TryGetValueAsync<TValue>(string key)
        {
            try
            {
                var json = await distributedCache.GetStringAsync(key);
                if (json == null)
                    return ConditionalValue<TValue>.None;

                var value = jsonSerializer.Deserialize<TValue>(json);
                return new ConditionalValue<TValue>(value);
            }
            catch (Exception exception)
            {
                logger.LogError(exception, $"key={key}");
                return ConditionalValue<TValue>.None;
            }            
        }

        public async Task RemoveAsync(string key)
        {            
            await distributedCache.RemoveAsync(key);
        }
        
        public async Task<ConditionalValue<TValue>> TryRemoveAsync<TValue>(string key)
        {
            try
            {
                var json = await distributedCache.GetStringAsync(key);
                if (json == null)
                    return ConditionalValue<TValue>.None;

                await distributedCache.RemoveAsync(key);

                var value = jsonSerializer.Deserialize<TValue>(json);
                return new ConditionalValue<TValue>(value);
            }
            catch (Exception exception)
            {
                logger.LogError(exception, $"key={key}");
                return ConditionalValue<TValue>.None;
            }                                    
        }
    }
}