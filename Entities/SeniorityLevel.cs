using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Entities{

    public class SeniorityLevel{

        [Key]
        public long Id { get; set; }
        public string Title { get; set; }= null!;
        public string Description { get; set; }= null!;
    }
}