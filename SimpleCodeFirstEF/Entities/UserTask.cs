using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleCodeFirstEF.Entities
{
    public class UserTask
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TaskId { get; set; }

        [Required]
        [MaxLength(48)]
        public string Title { get; set; } = string.Empty;

        [Required]
        public DateTime DueDate { get; set; }

        public int? AssignedTo { get; set; }

        [Required]
        //[ForeignKey("code")]
        public StatusCode? StatusCode { get; set; }

        public DateTime? DateTime { get; set; }

        [Required]
        public int CreatedBy { get; set; }
    }
}
