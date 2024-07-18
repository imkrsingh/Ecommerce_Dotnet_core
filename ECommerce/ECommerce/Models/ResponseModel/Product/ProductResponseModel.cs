using System.Collections.Generic;

namespace ECommerce.Models.ResponseModel.Product
{
    public class ProductResponseModel
    {
        //public int? Id { get; set; } // Assuming Id is of type int
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public string CategoryName { get; set; }

        public string ProductImage { get; set; }

    }
}

