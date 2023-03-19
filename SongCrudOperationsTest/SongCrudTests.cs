using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Services.HelpingClasses;
using Services.PrintInterfaces;
using Services.Services;
using Services.ViewModels;
using SongApplication.Infrastructure.Data;
using SongApplication.Models.Models;

namespace SongCrudOperationsTest
{
    public class SongCrudTests
    {
        private Print print = new Print();
        [Fact]
        public void Test_Add_Song_Should_Return_Success()
        {
            //Arange 

            var songCrudOperationsService = CreateService();

            AddSongViewModel song = new AddSongViewModel()
            {
                Title = "yes",
                Duration = 3,
                ReleaseDate = DateTime.Now,
            };
            // Act
            var result = songCrudOperationsService.AddSong(song);
            // Assert
            Assert.Equal("Success", result);
        }

        [Fact]
        public void Test_Add_Song_Should_Return_Failed()
        {
            //Arange 
            var songCrudOperationsService = CreateService();
            AddSongViewModel song = new AddSongViewModel()
            {
                Title = null,
            };
            // Act
            var result = songCrudOperationsService.AddSong(song);
            // Assert
            Assert.Equal("Failed", result);
        }

        [Fact]
        public void Test_Delete_Song_Should_Return_Failed()
        {
            //Arange 
            var songCrudOperationsService = CreateService();
            string songId = "KDC123DKX";
            // Act
            var result = songCrudOperationsService.DeleteSong(songId);
            // Assert
            Assert.Equal("Failed", result);
        }

        [Fact]
        public void Test_Get_All_Songs_Should_Return_Success()
        {
            //Arange 

            var songCrudOperationsService = CreateServiceWithRealDb();
            // Act
            var songs = songCrudOperationsService.GetAll();
            var result = print.CheckingNullMessage(songs);
            // Assert
            Assert.Equal("Success", result);
        }
        [Fact]
        public void Test_Get_Song_By_Id_Should_Return_Success()
        {
            //Arange 

            var songCrudOperationsService = CreateServiceWithRealDb();
            var songId = "33db3045-889f-4738-8287-54fb0fb88e47";
            // Act
            var song = songCrudOperationsService.GetById(songId);
            var result = print.CheckNullMessageForSingleItem(song);
            // Assert
            Assert.Equal("Success", result);
        }
        public void Test_Get_Song_By_Id_Should_Return_InvalidSongId()
        {
            //Arange 

            var songCrudOperationsService = CreateServiceWithRealDb();
            var songId = "55";
            // Act
            var song = songCrudOperationsService.GetById(songId);
            var result = print.CheckNullMessageForSingleItem(song);
            // Assert
            Assert.Equal("Invalid song id", result);
        }
        private SongCrudOperations CreateService()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
           .UseInMemoryDatabase(databaseName: "SongDatabase")
           .Options;
            ApplicationDbContext dbContext = new ApplicationDbContext(options);

            IPrintMessage print = new Print();
            IConfigurationProvider configuration = new MapperConfiguration(x =>
            {
                x.CreateMap<Song, SongViewModel>();
            });
            Mapper mapper = new Mapper(configuration);
            SongCrudOperations service = new SongCrudOperations(dbContext, print, mapper);
            return service;

        }
        private SongCrudOperations CreateServiceWithRealDb()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
           .UseSqlServer(@"Server=DESKTOP-LJHRUSL\SQLEXPRESS;Database=SongApplicationEntity;Trusted_Connection=True;TrustServerCertificate=True;").Options;
            ApplicationDbContext dbContext = new ApplicationDbContext(options);

            IPrintMessage print = new Print();
            IConfigurationProvider configuration = new MapperConfiguration(x =>
            {
                x.CreateMap<Song, SongViewModel>();
            });
            Mapper mapper = new Mapper(configuration);
            SongCrudOperations service = new SongCrudOperations(dbContext, print, mapper);
            return service;
        }
    }
}
