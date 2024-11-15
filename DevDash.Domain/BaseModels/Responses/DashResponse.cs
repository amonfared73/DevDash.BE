namespace DevDash.Domain.BaseModels.Responses
{
    public class DashResponse
    {
        public IEnumerable<string> Messages { get; set; }
        public DashResponse(string message) : this(new List<string>() { message }) { }
        public DashResponse(IEnumerable<string> messages)
        {
            Messages = messages;
        }
    }
}
