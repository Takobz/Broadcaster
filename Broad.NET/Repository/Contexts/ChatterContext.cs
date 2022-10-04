using Microsoft.EntityFrameworkCore;
using Broadcaster.Repository.Models;

namespace Broadcaster.Repository.Contexts 
{
    public class ChatterContext : DbContext, IChatterContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            var path  = System.IO.Path.Combine(Environment.CurrentDirectory, @"database\ChatterDatabse.db");
            builder.UseSqlite($"Filename={path}");
        }
    }
}