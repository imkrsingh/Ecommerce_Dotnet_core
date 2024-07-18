namespace TodoApi.Models
{
    public class Student
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public int Grade { get; set; }
    }

    public class Grade
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }
    }
}
