using System;
using System.Threading;
using System.Threading.Tasks;
using Forms.Driving.Configuration;
using Forms.Driving.Data;
using Newtonsoft.Json;

namespace Forms.Driving.Infrastructure
{
    public class TokenStore
    {
        public event EventHandler Changed;

        private readonly ISettings settings;
        private readonly ILogger logger;
        private TokenResponse currentValue;

        public TokenStore(ISettings settings, ILogger logger)
        {
            this.settings = settings;
            this.logger = logger;
        }

        public TokenResponse Get()
        {
            return currentValue ?? (TryGet(out var value) ? (currentValue = value) : null);            
        }

        private bool TryGet(out TokenResponse value)
        {
            try
            {
                var json = settings.LastTokenData;
                value = JsonConvert.DeserializeObject<TokenResponse>(json);
                return value != null;
            }
            catch (Exception exception)
            {
                logger.Error(exception);

                value = null;
                return false;
            }
        }

        public async Task<TokenResponse> UpdateAsync(Func<CancellationToken, Task<TokenResponse>> updateFunc,
                                                     CancellationToken cancellationToken = default(CancellationToken))
        {
            var value = await updateFunc(cancellationToken);
            Update(value);

            return value;
        }

        public void Update(TokenResponse tokenResponse)
        {
            currentValue = tokenResponse;
            using (var editor = settings.CreateEditor())
            {
                editor.LastTokenResponse = JsonConvert.SerializeObject(currentValue);
                editor.Apply();
            }

            Changed?.Invoke(this, EventArgs.Empty);
        }

        public void Clean()
        {
            Update(null);
        }
    }
}
