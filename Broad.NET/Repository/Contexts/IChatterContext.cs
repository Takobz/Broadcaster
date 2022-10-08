using Broadcaster.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace Broadcaster.Repository.Contexts
{
    public interface IChatterContext 
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
        public int SaveChanges();
    }
}