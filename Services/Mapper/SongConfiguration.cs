using AutoMapper;
using Services.ViewModels;
using SongApplication.Models.Models;

namespace Services.Mapper
{
    public class SongConfiguration : Profile
    {
        public SongConfiguration()
        {
            CreateMap<Song, SongViewModel>().ReverseMap();
        }
    }
}
