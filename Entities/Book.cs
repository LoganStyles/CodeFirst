using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Entities
{
    public class Book
    {
        [Key]
        public long ISBN { get; set; }

        public string Title { get; set; } = null!;
    }
}
