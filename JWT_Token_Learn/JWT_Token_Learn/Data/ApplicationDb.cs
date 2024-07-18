using JWT_Token_Learn.Models;
using Microsoft.EntityFrameworkCore;

namespace JWT_Token_Learn.Data
{
    public class ApplicationDb:DbContext
    {
        public ApplicationDb(DbContextOptions options) : base(options)
        {

        }
        public DbSet<SignUp> employees { get; set; }
       // public DbSet<User> users { get; set; }
    }
}
