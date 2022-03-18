using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Entities
{
    [Table("tbl_Publishers")]
    public class Publisher
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string Address { get; set; } = null!;

        [NotMapped]
        public string State { get; set; } = null!;
    }
}
