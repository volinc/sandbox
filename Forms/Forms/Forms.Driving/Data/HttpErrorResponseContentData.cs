using System.Collections.Generic;

namespace Forms.Driving.Data
{
    public class HttpErrorResponseContentData
    {
        public ICollection<ErrorDescriptorData> Errors { get; } = new List<ErrorDescriptorData>();
    }
}