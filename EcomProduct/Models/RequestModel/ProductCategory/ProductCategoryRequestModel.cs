using System.ComponentModel.DataAnnotations;

namespace EcomProduct.Models.RequestModel.ProductCategory
{
    public class ProductCategoryRequestModel
    {
        [Required]
        public int productCategoryId {  get; set; }

        [Required]
        public string productCategoryName { get; set; }

        public string Description { get; set; }
    }
}
