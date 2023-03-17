namespace SongApplication.Models.Interfaces
{
    public interface IBaseModel : IDateInfo
    {
        public string Id { get; set; }
    }
}
