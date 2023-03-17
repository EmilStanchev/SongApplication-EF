using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SongApplication.Models.Models;
namespace SongApplication.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
        public DbSet<Song> Songs { get; set; }
        /*   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
           {
               optionsBuilder.UseSqlServer(@"Server=DESKTOP-LJHRUSL\SQLEXPRESS;Database=SongApplicationEntity;Trusted_Connection=True;TrustServerCertificate=True;");
           }*/
    }
}
