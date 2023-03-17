using SongApplication.Models.Interfaces;

namespace SongApplication.Models.Models
{
    public class BaseModel : IBaseModel
    {
        public BaseModel()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
