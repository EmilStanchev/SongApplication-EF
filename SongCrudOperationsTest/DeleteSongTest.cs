using Microsoft.EntityFrameworkCore;
using Services.HelpingClasses;
using Services.Services;
using SongApplication.Infrastructure.Data;

namespace SongCrudOperationsTest
{
    public class DeleteSongTest
    {
        private readonly ApplicationDbContext _context;
        public DeleteSongTest()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "MyAppTestDatabase")
                .Options;

            //      _context = new ApplicationDbContext(options);
        }
        [Fact]
        public void Test_Delete_Song_Should_Return_Failed()
        {
            //Arange 

            SongCrudOperations crudOperations = new SongCrudOperations(_context, new Print());
            string songId = "KDC123DKX";
            // Act
            var result = crudOperations.DeleteSong(songId);
            // Assert
            Assert.Equal("Failed", result);
        }
    }
}
