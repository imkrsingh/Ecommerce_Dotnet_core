namespace EcomProduct.Entities
{
    public class FileUpload
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ? ImgName { get; set; } //Add
        public string ImgURL { get; set; } //Add
        //public string ? FileName  { get; set; }
        public Product Product { get; set; }

    }
}
