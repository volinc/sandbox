namespace Taxys.Security.Models
{
    using Microsoft.AspNetCore.Http;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;
    using Taxys.WebApi;

    public class UnauthorizedResult
    {        
        public UnauthorizedResult(string message)
        {
            Value = JsonApiErrorsHelper.BuildContent(message);
            StatusCode = StatusCodes.Status401Unauthorized;
        }
        
        [DataMember(Name = "statusCode")]
        [JsonPropertyName("statusCode")]
        public int? StatusCode { get; set; }

        [DataMember(Name = "value")]
        [JsonPropertyName("value")]
        public JsonApiErrors Value { get; set; }
    }
}
