namespace Taxys.Security
{
    using System;
    using Microsoft.AspNetCore.Authentication;
    using Microsoft.AspNetCore.Authentication.JwtBearer;

    public static class AuthenticationBuilderExtensions
    {    
        public static AuthenticationBuilder AddCustomJwtBearer(this AuthenticationBuilder builder)
        {            
            return builder.AddScheme<CustomJwtBearerOptions, CustomAuthHandler>(
                JwtBearerDefaults.AuthenticationScheme, options => { });
        }

        public static AuthenticationBuilder AddCustomJwtBearer(this AuthenticationBuilder builder, Action<CustomJwtBearerOptions> configureOptions)
        {
            return builder.AddScheme<CustomJwtBearerOptions, CustomAuthHandler>(
                JwtBearerDefaults.AuthenticationScheme, configureOptions);
        }
    }
}
