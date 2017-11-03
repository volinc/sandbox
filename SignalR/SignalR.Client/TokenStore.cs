namespace SignalR.Client
{
    public class TokenStore
    {
        public TokenResponse Get()
        {
            return new TokenResponse
            {
                AccessToken = string.Empty                
            };
        }
    }
}
