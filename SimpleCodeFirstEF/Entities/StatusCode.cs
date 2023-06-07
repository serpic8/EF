using System.ComponentModel.DataAnnotations;

namespace SimpleCodeFirstEF.Entities
{
    public class StatusCode
    {
        [Key]
        [MaxLength(3)]
        public string Code { get; set; } = string.Empty;

        [Required]
        [MaxLength(20)]
        public string Description { get; set; } = string.Empty;
    }
}
