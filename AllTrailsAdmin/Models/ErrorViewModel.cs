namespace AllTrailsAdmin.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }// ? means can be null

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
