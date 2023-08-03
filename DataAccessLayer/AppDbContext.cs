using Microsoft.EntityFrameworkCore;
using PodTalk.DataAccessLayer.Entity;

namespace PodTalk.DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Footer> Footer { get; set; }
        public DbSet<SocialMedia> SocialMedia { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}
