using System.ComponentModel.DataAnnotations;

namespace MessageBoard.Models
{
    public class Message
    {
        public int MessageId { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Body { get; set; }
        [Required]
        public string Group { get; set; }
    }
}