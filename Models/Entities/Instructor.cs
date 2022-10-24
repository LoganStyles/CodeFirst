namespace CodeFirst.Models.Entities
{

    public class Instructor
    {

        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long DeptId { get; set; }
        public decimal Salary { get; set; }

        public Course Course { get; set; }
    }
}