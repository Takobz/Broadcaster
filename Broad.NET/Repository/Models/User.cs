using System.ComponentModel.DataAnnotations.Schema;

namespace Broadcaster.Repository.Models
{
    public class User
    {
        //adding nullable string as C# throws warning: CS8618
        public int UserId { get; set; }
        public string Username { get; set;}
        public string Password { get; set; }
    }
}