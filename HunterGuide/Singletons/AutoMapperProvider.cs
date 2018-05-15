using AutoMapper;
using HunterGuide.Util;

namespace HunterGuide.Singletons 
{
    public class AutoMapperProvider 
    {
        private static AutoMapperProvider provider;
        private IMapper mapper;

        private AutoMapperProvider() 
        {
            MapperConfiguration configMapper = new MapperConfiguration(
                cfg => { cfg.AddProfile(new AutoMapperProfile()); }
            );
            mapper = new Mapper(configMapper);
        }

        public static IMapper GetIMapper() 
        {
            if (provider == null) 
            {
                provider = new AutoMapperProvider();
            }
            return provider.mapper;
        }
    }
}
