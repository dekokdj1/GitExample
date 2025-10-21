namespace GitExample.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }
        //Another change for github
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
