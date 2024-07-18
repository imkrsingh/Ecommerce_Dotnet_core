using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EFCoreTutorialConsole
{
    public class SchoolContext : DbContext
    {
        //entities

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }


        public SchoolContext(DbContextOptions<SchoolContext> options)
         : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SchoolDB;Trusted_Connection=True;");
        //}
    }
}
