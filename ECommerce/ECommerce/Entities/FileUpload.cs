using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Entities
{
    public class FileUpload
    {
        public int Id { get; set; }
        public int ProductId { get; set; }  

        public string FileName { get; set; }
        public Product Product { get; set; }

    }
}
