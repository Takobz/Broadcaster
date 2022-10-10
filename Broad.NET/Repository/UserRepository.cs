using Broadcaster.Repository.Contexts;
using Broadcaster.Repository.Models;

namespace Broadcaster.Repository
{
    public interface IUserRepository
    {
        void CreateUser(User user);
        User GetUserByUsername(string username);
    }

    public class UserRepository : IUserRepository
    {
        private readonly IChatterContext _chatterContext;
        public UserRepository(IChatterContext chatterContext)
        {
            _chatterContext = chatterContext ?? throw new ArgumentNullException(nameof(chatterContext));
        }

        public void CreateUser(User user)
        {
            _chatterContext.Users.Add(user);
            _chatterContext.SaveChanges();
        }

        public User GetUserByUsername(string username)
        {
           var user = _chatterContext.Users.FirstOrDefault(x => x.Username == username);
           return user ?? new User();
        }
    }
}