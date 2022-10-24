namespace CodeFirst.Models.Entities
{

    public class Course
    {

        public long Id { get; set; }
        public string Title { get; set; }
        public long InstructorId { get; set; }

        public Instructor Instructor { get; set; }
    }
}