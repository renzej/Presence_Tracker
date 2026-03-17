using System.ComponentModel.DataAnnotations;

namespace Presence.Web.Models
{
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

    public class Event
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime Date { get; set; }

        public EventType Type { get; set; }
    }
}
