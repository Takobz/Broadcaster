using System.ComponentModel.DataAnnotations.Schema;

namespace Broadcaster.Repository.Models
{
    public class Message
    {
        public int MessageID { get; set; }
        public int FromID { get; set; }
        public int ToID { get; set; }
        [Column("Message")]
        public string Text { get; set; }

        [ForeignKey("ToID")]
        public User Recipient { get; set; }
        [ForeignKey("FromID")]
        public User Sender { get; set; }
    }
}