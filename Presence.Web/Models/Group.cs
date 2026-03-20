using System.ComponentModel.DataAnnotations;

namespace Presence.Web.Models
{
    public class Group
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public bool IsActive { get; set; } = true;

        public ICollection<Member> Members { get; set; }
    }
}
