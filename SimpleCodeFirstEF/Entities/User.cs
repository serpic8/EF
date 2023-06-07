using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleCodeFirstEF.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Required] 
        [MaxLength(32)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(32)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [MaxLength(32)]
        public string CellPhone { get; set; } = string.Empty;

        [Required]
        [MaxLength(132)]
        public string Email { get; set; } = string.Empty;

        [Required]
        public DateTime MemberSince { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Required]
        public bool CanReAssin { get; set; }
    }
}
