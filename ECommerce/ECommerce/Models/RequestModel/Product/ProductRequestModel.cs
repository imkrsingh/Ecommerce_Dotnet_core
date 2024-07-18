using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using ECommerce.Entities;

namespace ECommerce.Models.RequestModel.Product
{
    public class ProductRequestModel
    {
        public string Name { get; set; }
        public string ? Description { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }              
        public int ProductCategoryId { get; set; }
        public IFormFile? Image { get; set; }
    }

}

