using Services.ViewModels;

namespace Services.Contracts
{
    public interface ISongCrudOperations
    {
        public List<SongViewModel> GetAll();
        public SongViewModel GetById(string id);
        public string AddSong(AddSongViewModel song);
        public string DeleteSong(string id);
        public void UpdateSong(AddSongViewModel song);
    }
}
