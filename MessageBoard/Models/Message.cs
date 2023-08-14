namespace MessageBoard.Models
{
    public class Message
    {
        public int MessageId { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Group { get; set; }
    }
}