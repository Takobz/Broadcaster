using Broadcaster.Repository.Contexts;
using Broadcaster.Repository.Models;

namespace Broadcaster.Repository
{
    public interface IMessageRepository
    {
        void CreateMessage(Message message);
        ICollection<Message> GetMessagesSentToUsernameByUsername(string sentToUsername, string sentByUsername);
    }

    public class MessageRepository : IMessageRepository
    {
        IChatterContext _chatterContext;
        public MessageRepository(IChatterContext chatterContext)
        {
            _chatterContext = chatterContext;
        }

        public void CreateMessage(Message message)
        {
            _chatterContext.Messages.Add(message);
            _chatterContext.SaveChanges();
        }

        public ICollection<Message> GetMessagesSentToUsernameByUsername(string sentToUsername, string sentByUsername)
        {
            return _chatterContext.Messages.Where(x => x.Sender.Username == sentByUsername
             && x.Recipient.Username == sentToUsername).ToList();
        }
    }
}