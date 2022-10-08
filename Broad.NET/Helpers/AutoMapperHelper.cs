using AutoMapper;

namespace Broadcaster.Helpers 
{
    public interface IAutoMapperHelper 
    {
        public Mapper MapperTo<TSource, TDestination>();
    }

    public class AutoMapperHelper : IAutoMapperHelper 
    {

        public Mapper MapperTo<TSource, TDestination>()
        {
            var config = new MapperConfiguration(config => config.CreateMap<TSource, TDestination>());
            return new Mapper(config);
        }
    }
}