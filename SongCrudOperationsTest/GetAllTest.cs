using Microsoft.EntityFrameworkCore;
using Services.HelpingClasses;
using Services.Services;
using SongApplication.Infrastructure.Data;

namespace SongCrudOperationsTest
{
    public class GetAllTest
    {
        private readonly ApplicationDbContext _context;
        private Print print = new Print();
        public GetAllTest()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "MyAppTestDatabase")
                .Options;

            _context = new ApplicationDbContext(options);
        }
        [Fact]
        public void Test_Get_All_Songs_Should_Return_Success()
        {
            //Arange 

            SongCrudOperations crudOperations = new SongCrudOperations(_context, new Print());
            // Act
            var songs = crudOperations.GetAll();
            var result = print.CheckingNullMessage(songs);
            // Assert
            Assert.Equal("Success", result);
        }
    }
}
