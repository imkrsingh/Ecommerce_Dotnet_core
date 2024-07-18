using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class StudentContext:DbContext
    {
        internal object TodoItems;
        internal object studentItem;

        public StudentContext(DbContextOptions<StudentContext> options)
         : base(options)
        {
        }

        public DbSet<Student> StudentItem { get; set; } = null!;
        public object StudentItems { get; internal set; }
    }
}