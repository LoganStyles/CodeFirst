using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Entities
{
    public class Employee
    {
        public Employee()
        {
            Albums = new HashSet<Album>();
        }

        [Key]
        public long Id { get; set; }
        public string FirstName { get; set; }= null!;
        public string LastName { get; set; }= null!;
        public long Age { get; set; }
        public long SeniorityLevelId { get; set; }

        [ForeignKey(nameof(SeniorityLevelId))]
        [InverseProperty("Employee")]
        public virtual SeniorityLevel SeniorityLevel { get; set; } = null!;

        [InverseProperty("Employee")]
        public virtual Studio Studio { get; set; }= null!;
        
        [InverseProperty(nameof(Album.Employee))]
        public virtual ICollection<Album> Albums { get; set; }
    }
}




