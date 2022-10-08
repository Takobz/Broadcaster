using AutoMapper;
using Broadcaster.Repository.Models;

namespace Broadcaster.Models.AutoMapperProfilers
{
    public class MessageProfiler : Profile
    {
        public MessageProfiler()
        {
            CreateMap<Message, MessageModel>();
        }
    }
}