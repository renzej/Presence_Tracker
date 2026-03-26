using System.ComponentModel.DataAnnotations;

namespace Presence.Web.Models
{
    // Event Type
    public enum EventType
    {
        [Display(Name = "Church Service")]
        ChurchService = 0,

        [Display(Name = "Prayer Meeting")]
        PrayerMeeting = 1,

        [Display(Name = "Special Event")]
        SpecialEvent = 2,

        Other = 3
    }

    // Event Status
    public enum EventStatus
    {
        [Display(Name = "Upcoming")]
        Upcoming = 0,

        [Display(Name = "Ongoing")]
        Ongoing = 1,

        [Display(Name = "Completed")]
        Completed = 2
    }

    public class Event
    {
        [Key]
        public int Id { get; set; }

        // Name of event
        [Required]
        public string Name { get; set; }

        // Start Time
        public DateTime StartDateTime { get; set; }

        // End Time (optional)
        public DateTime? EndDateTime { get; set; }

        // Type of event
        public EventType Type { get; set; }

        // Status of the event
        public EventStatus Status { get; set; } = EventStatus.Upcoming;
    }
}
