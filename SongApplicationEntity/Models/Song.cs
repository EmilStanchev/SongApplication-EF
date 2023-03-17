namespace SongApplication.Models.Models
{
    public class Song : BaseModel
    {
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Duration { get; set; }

    }
}
