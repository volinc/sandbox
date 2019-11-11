namespace Taxys.Security.Models
{
    using Microsoft.AspNetCore.Http;
    using Taxys.WebApi;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [DataContract]
    public class ForbidResult
    {        
        public ForbidResult(string message)
        {
            Value = JsonApiErrorsHelper.BuildContent(message);
            StatusCode = StatusCodes.Status403Forbidden;
        }
        
        [DataMember(Name ="statusCode")]
        [JsonPropertyName("statusCode")]
        public int? StatusCode { get; set; }

        [DataMember(Name = "value")]
        [JsonPropertyName("value")]
        public JsonApiErrors Value { get; set; }
    }
}
