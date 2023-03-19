using Microsoft.EntityFrameworkCore;
using Services.HelpingClasses;
using Services.Services;
using Services.ViewModels;
using SongApplication.Infrastructure.Data;

namespace SongCrudOperationsTest
{
    public class AddSongTest
    {
        private readonly ApplicationDbContext _context;
        public AddSongTest()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "MyAppTestDatabase")
                .Options;

            //  _context = new ApplicationDbContext(options);
        }
        [Fact]
        public void Test_Add_Song_Should_Return_Success()
        {
            //Arange 

            SongCrudOperations crudOperations = new SongCrudOperations(_context, new Print());
            AddSongViewModel song = new AddSongViewModel()
            {
                Title = "yes",
                Duration = 3,
                ReleaseDate = DateTime.Now,
            };
            // Act
            var result = crudOperations.AddSong(song);
            // Assert
            Assert.Equal("Success", result);
        }

        [Fact]
        public void Test_Add_Song_Should_Return_Failed()
        {
            //Arange 
            SongCrudOperations crudOperations = new SongCrudOperations(_context, new Print());
            AddSongViewModel song = new AddSongViewModel()
            {
                Title = null,
            };
            // Act
            var result = crudOperations.AddSong(song);
            // Assert
            Assert.Equal("Failed", result);
        }
    }
}