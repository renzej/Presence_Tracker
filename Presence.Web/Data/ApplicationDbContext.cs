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
                new Event { Id = 1, Name = "March Prayer Meeting", StartDateTime = new DateTime(2025, 3, 5, 18, 0, 0), EndDateTime = new DateTime(2025, 3, 5, 20, 0, 0), Type = EventType.PrayerMeeting, Status = EventStatus.Completed },
                new Event { Id = 2, Name = "Brother CJ Sermon", StartDateTime = new DateTime(2025, 3, 9, 9, 0, 0), EndDateTime = new DateTime(2025, 3, 9, 12, 0, 0), Type = EventType.ChurchService, Status = EventStatus.Completed },
                new Event { Id = 3, Name = "Brother Jan Sermon", StartDateTime = new DateTime(2025, 3, 16, 9, 0, 0), EndDateTime = new DateTime(2025, 3, 16, 12, 0, 0), Type = EventType.ChurchService, Status = EventStatus.Completed },
                new Event { Id = 4, Name = "Band Practice", StartDateTime = new DateTime(2025, 3, 20, 17, 0, 0), Type = EventType.Other, Status = EventStatus.Completed }
            );
        }
    }
}
