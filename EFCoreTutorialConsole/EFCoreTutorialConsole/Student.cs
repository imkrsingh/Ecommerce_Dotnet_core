public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public int GradeId { get; set; } // Assuming GradeId is a foreign key
    public Grade Grade { get; set; } // Assuming Grade is a navigation property
}
