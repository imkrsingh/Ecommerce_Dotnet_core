using EcomProduct.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EcomProduct.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ImageController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("upload/{productId}")]
        public async Task<IActionResult> Upload(int productId, IFormFile[] files)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null)
            {
                return NotFound("Product not found.");
            }

            if (files == null || files.Length == 0)
            {
                return BadRequest("No files selected.");
            }

            var fileUploads = new List<ProductImage>();

            foreach (var file in files)
            {
                if (file.Length > 0)
                {
                    // Ensure the file name is unique
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", fileName);

                    try
                    {
                        // Save the file
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            await file.CopyToAsync(stream);
                        }

                        var fileUpload = new ProductImage
                        {
                            ProductId = productId,
                            ImgName = Path.GetFileNameWithoutExtension(file.FileName), // Optional name for the image
                            ImgURL = $"/images/{fileName}" // URL to access the image
                        };

                        fileUploads.Add(fileUpload);
                    }
                    catch (IOException ex)
                    {
                        return StatusCode(StatusCodes.Status500InternalServerError, $"Error saving file: {ex.Message}");
                    }
                }
            }

            if (fileUploads.Any())
            {
                _context.ProductImages.AddRange(fileUploads);
                await _context.SaveChangesAsync();
            }

            return Ok(new { fileUrls = fileUploads.Select(fu => fu.ImgURL) });
        }

        [HttpGet("{productId}")]
        public async Task<IActionResult> GetImages(int productId)
        {
            var product = await _context.Products
                .Include(p => p.ProductImages)
                .FirstOrDefaultAsync(p => p.Id == productId);

            if (product == null)
            {
                return NotFound("Product not found.");
            }

            var imageUrls = product.ProductImages.Select(img => new { imgUrl = img.ImgURL }).ToList();

            return Ok(imageUrls);
        }
    }
}
