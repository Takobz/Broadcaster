using System.ComponentModel.DataAnnotations.Schema;

namespace Broadcaster.Repository.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set;}
    }
}