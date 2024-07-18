using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Entities
{
    public class Product
    {  
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public int ProductCategoryId { get; set; }

        public ProductCategory ProductCategory { get; set; }

       public string ProductImage { get; set; }
       public ICollection<ProductImage> ProductImages { get; set; }
    }
}
