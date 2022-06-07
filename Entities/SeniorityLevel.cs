using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Entities
{
    public class SeniorityLevel
    {
        [Key]
        public long Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        
        [InverseProperty("SeniorityLevel")]
        public virtual Employee Employee { get; set; }= null!;
    }
}



