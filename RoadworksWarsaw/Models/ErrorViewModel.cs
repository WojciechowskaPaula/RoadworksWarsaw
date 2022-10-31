namespace RoadworksWarsaw.Models
{
    public class ErrorViewModel
    {
        public ErrorViewModel()
        {
            this.Message = "Something went wrong, please try again later.";
        }
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public object Message { get; private set; }
    }
}