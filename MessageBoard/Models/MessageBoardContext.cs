using Microsoft.EntityFrameworkCore;

namespace MessageBoard.Models
{
    public class MessageBoardContext : DbContext
    {
        public DbSet<Message> Messages { get; set; }

        public MessageBoardContext(DbContextOptions<MessageBoardContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Message>()
            .HasData(
                new Message { MessageId = 1, Subject = "Loud Party", Body = "Very loud, rude, teens throwing a party in the SW Neighborhood", Group = "SW Neighborhood Watch" },
                new Message { MessageId = 2, Subject = "Block party", Body = "Good times, bring all your friends", Group = "Gen zs unite" }
            );
        }
    }
}

//    public int MessageId { get; set; }
//         public string Subject { get; set; }
//         public string Body { get; set; }
//         public string Group { get; set; }