using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SongApplication.Models.Models;

namespace SongApplication.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext()
        : base()
        {
        }
        public DbSet<Song> Songs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-LJHRUSL\SQLEXPRESS;Database=SongApplicationEntity;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            var firstSong = new Song { Title = "Lose Yourself", Duration = 4.50M, ReleaseDate = new DateTime(2010, 12, 25) };
            var secondSong = new Song { Title = "Mockingbird", Duration = 3.46M, ReleaseDate = new DateTime(2013, 12, 25) };
            var thirdSong = new Song { Title = "Be Somebody", Duration = 3.43M, ReleaseDate = new DateTime(2013, 12, 25) };
            var fourthSong = new Song { Title = "Hangover", Duration = 4.44M, ReleaseDate = new DateTime(2013, 12, 25) };
            var fifthSong = new Song { Title = "Whistle", Duration = 4.26M, ReleaseDate = new DateTime(2013, 12, 25) };

            modelBuilder.Entity<Song>().HasData(firstSong, secondSong, thirdSong, fourthSong, fifthSong);
            base.OnModelCreating(modelBuilder);
        }
    }
}
