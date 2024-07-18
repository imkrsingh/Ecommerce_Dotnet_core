using ECommerce.Entities; // Ensure correct namespace for your entities
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Data
{
    public class ApplicationDb : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDb(DbContextOptions<ApplicationDb> options) : base(options)
        {
        }

        // Custom entity sets
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }

    }
}

