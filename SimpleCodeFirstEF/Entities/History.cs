using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleCodeFirstEF.Entities
{
    public class History
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HId { get; set; }
        public int? TaskId { get; set; }
        public int? UserId { get; set; }



    }
}
