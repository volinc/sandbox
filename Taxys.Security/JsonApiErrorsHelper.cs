namespace Taxys.Security
{
    using Taxys.WebApi;

    public static class JsonApiErrorsHelper
    {
        public static JsonApiErrors BuildContent(string title) => new JsonApiErrors
        {
            Errors = new[]
            {
                new JsonApiErrorObject {Title = title}
            }
        };
    }
}
