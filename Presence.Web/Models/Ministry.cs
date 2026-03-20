using System.ComponentModel.DataAnnotations;

namespace Presence.Web.Models
{
    public class Ministry
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public bool isActive { get; set; } = true;

        //Navigation property
        public ICollection<MemberMinistry> MemberMinistries { get; set; }
    }
}
