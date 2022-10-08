using AutoMapper;
using Broadcaster.Repository.Models;

namespace Broadcaster.Models.AutoMapperProfilers
{
    public class UserProfiler : Profile 
    {
        public UserProfiler()
        {
            CreateMap<User, UserModel>();
        }
    }
}