using System.ComponentModel.DataAnnotations;

namespace ECommerce.Entities
{
    public class ProductCategory
    {

        [Key]
       public int Id { get; set; }
       public string CategoryName { get; set; }
        public string? Description { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
