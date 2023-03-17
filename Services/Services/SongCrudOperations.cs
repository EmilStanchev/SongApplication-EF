using AutoMapper;
using Services.Contracts;
using Services.PrintInterfaces;
using Services.ViewModels;
using SongApplication.Infrastructure.Data;
using SongApplication.Models.Models;

namespace Services.Services
{
    public class SongCrudOperations : ISongCrudOperations
    {
        private readonly ApplicationDbContext context;
        private IPrintMessage _message;
        public SongCrudOperations(ApplicationDbContext applicationDbContext, IPrintMessage message)
        {
            context = applicationDbContext;
            _message = message;
        }

        public string AddSong(AddSongViewModel song)
        {
            try
            {
                Song dbSong = new Song()
                {
                    Title = song.Title,
                    Duration = song.Duration,
                    ReleaseDate = song.ReleaseDate,
                };
                context.Songs.Add(dbSong);
                int res = context.SaveChanges();
                return _message.Message(res);
            }
            catch (Exception ex)
            {
                return "Failed";
            }
        }
        public string DeleteSong(string id)
        {
            try
            {
                var songForDelete = context.Songs.SingleOrDefault(s => s.Id == id);
                context.Songs.Remove(songForDelete);
                int res = context.SaveChanges();
                return _message.Message(res);
            }
            catch (Exception)
            {
                return "Failed";
            }

        }

        public List<SongViewModel> GetAll()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Song, SongViewModel>();
            });
            var mapper = config.CreateMapper();
            var songs = context.Songs.Select(s => s).ToList();
            var result = mapper.Map<List<SongViewModel>>(songs);
            return result;
        }

        public SongViewModel GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void UpdateSong(AddSongViewModel song)
        {
            throw new NotImplementedException();
        }
    }
}
