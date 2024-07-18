using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models.RequestModel.ProductCategory
{
    public class ProductCategoryRequestModel
    {
        [Required]
        public string CategoryName { get; set; }

        public string Description { get; set; }
    }
}
