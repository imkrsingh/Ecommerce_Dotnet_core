namespace EFCoreTutorialConsole.Models.Responses
{
    public class StudentDtoResponse
    {
            public int Id { get; set; }
        public string FullName { get; set; }
            public string Email { get; set; }
        //public GradeDto Grade { get; set; }
        public string GradeName {  get; set; }
        public string GradeDescription { get; set; }
            //public string GradeName { get; set; }
            //public string GradeDescription { get; set; }

    }
}
