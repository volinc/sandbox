namespace Taxys.Security
{
    using Microsoft.AspNetCore.Authentication;
    using Microsoft.AspNetCore.Authentication.JwtBearer;

    public class CustomJwtBearerOptions : AuthenticationSchemeOptions
    {
        public string Scheme => JwtBearerDefaults.AuthenticationScheme;        
    }
}
