using System;
using Forms.Driving.Extensions;

namespace Forms.Driving.Infrastructure
{
    public class ServiceClientConfiguration
    {
        public string ApiTokensPath { get; set; } = "tokens";

        public string ApiPath { get; set; } = "api/v1/driver/";

        public string ApiAuthority { get; set; } =

#if DEBUG
    "http://10.0.2.2:57749";
#else
    "http://dev.inbest.pro";
#endif

        public TimeSpan? Timeout { get; set; } = TimeSpan.FromSeconds(40);

        public TimeSpan? SpecTimeout { get; set; } = TimeSpan.FromSeconds(60);

        public Uri BaseUri => new UriBuilder(ApiAuthority).SetPath(ApiPath).Uri;

        public Uri TokensUri => new UriBuilder(ApiAuthority).SetPath(ApiPath).SetPath(ApiTokensPath).Uri;
    }
}
