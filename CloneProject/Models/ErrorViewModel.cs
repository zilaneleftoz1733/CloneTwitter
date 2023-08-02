using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CloneProject.Models
{

    public class ErrorViewModel
    {
       
        
            public int StatusCode { get; set; }
            public string? Message { get; set; }
            public Exception? Exception { get; set; }
        public string? RequestId { get; internal set; }
    }

}
