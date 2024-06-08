using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace WebApplication1.Models
{
    public class WebSportsAppDbContext : IdentityDbContext
    {
        public WebSportsAppDbContext(DbContextOptions<WebSportsAppDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
       
        public DbSet<ContactInfo> ContactInfoes { get; set; }
        public DbSet<Recenzie> Recenzii { get; set; }

        public DbSet<Inregistrare> Inregistrare { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }

    }
}
