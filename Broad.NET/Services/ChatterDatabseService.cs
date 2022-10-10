using System.Collections.Generic;
using Broadcaster.Models;
using Broadcaster.Repository;

namespace Broadcaster.Services
{
    public interface IChatterDatabaseService
    {
        UserModel GetUserByUsername(string username);
        ICollection<MessageModel> GetMessagesSentToUserByUsername(string sentToUsername, string recipientUsername);
        void CreateUser(UserModel user);
    }

    public class ChatterContextService : IChatterDatabaseService
    {
        private readonly IMessageRepository _messageRepository;
        private readonly IUserRepository _userRepository;
        public ChatterContextService(
            IMessageRepository messageRepository,
            IUserRepository userRepository)
        {
            _messageRepository = messageRepository;
            _userRepository = userRepository;
        }

        public void CreateUser(UserModel user)
        {
            throw new NotImplementedException();
        }

        public ICollection<MessageModel> GetMessagesSentToUserByUsername(string sentToUsername, string recipientUsername)
        {
            throw new NotImplementedException();
        }

        public UserModel GetUserByUsername(string username)
        {
            throw new NotImplementedException();
        }
    }
}