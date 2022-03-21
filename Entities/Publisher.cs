using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Entities
{
    [Table("tbl_Publishers")]
    public class Publisher
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [Column("Title", TypeName ="varchar(200)")]
        public string Name { get; set; } = null!;

        [Required]
        [Comment("The address of the publisher")]
        [MaxLength(200)]
        public string Address { get; set; } = null!;

        [NotMapped]
        public string State { get; set; } = null!;
    }
}
