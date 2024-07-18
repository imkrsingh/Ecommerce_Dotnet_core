using System.Collections.Generic;
using EcomProduct.Models.RequestModel.Product;

namespace EcomProduct.Models.ResponseModel.Product
{
    public class ProductResponseModel
    {
        public int? Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int productCategoryId { get; set; }
        public string CategoryName { get; set; }
        //public string ProductImage { get; set; }
        public List<ProductImageResponseModel> ProductImages { get; set; } //Add

    }
}

