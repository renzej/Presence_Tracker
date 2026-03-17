using Microsoft.EntityFrameworkCore;
using Presence.Web.Models;

namespace Presence.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        // Table Creations
        public DbSet<Event> Events { get; set; }

        //Seed Data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>().HasData(
                new Event { Id = 1, Name = "March Prayer Meeting", Date = new DateTime(2026, 3, 18), Type = EventType.PrayerMeeting },
                new Event { Id = 2, Name = "Church Service", Date = new DateTime(2026, 3, 22), Type = EventType.ChurchService },
                new Event { Id = 3, Name = "Band Practice", Date = new DateTime(2026, 3, 20), Type = EventType.Other }
            );
        }
    }
}
