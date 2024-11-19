using AgriculturePresentation.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace AgriculturePresentation.DataAccess.Contexts
{
    public class AgriculturePresentationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Bayte;database=DbAgriculturePresentation;integrated security=true");
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Team> Teams { get; set; }

    }
}