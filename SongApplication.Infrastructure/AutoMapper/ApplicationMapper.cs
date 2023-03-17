using AutoMapper;

namespace SongApplication.Infrastructure.AutoMapper
{
    public class ApplicationMapper
    {
        public static void Configure()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Object, Object>();
            });
            var mapper = config.CreateMapper();
        }
    }
}
