// ECommerce.Controllers.ImageController.cs
using ECommerce.Data;
using ECommerce.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private readonly ApplicationDb _context;

        public ImageController(ApplicationDb context)
        {
            _context = context;
        }

        [HttpPost("upload/{productId}")]
        public async Task<IActionResult> Upload(int productId, IFormFile[] files)  // Change to handle multiple files
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null)
            {
                return NotFound();
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
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", fileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }

                    var fileUpload = new ProductImage
                    {
                        ProductId = productId,
                        FileName = fileName
                    };

                    fileUploads.Add(fileUpload);
                }
            }

            if (fileUploads.Any())
            {
                _context.ProductImages.AddRange(fileUploads);
                await _context.SaveChangesAsync();
            }

            return Ok(new { fileUrls = fileUploads.Select(fu => "/images/" + fu.FileName) });
        }

        [HttpGet("{productId}")]
        public async Task<IActionResult> GetImages(int productId)
        {
            var product = await _context.Products
                .Include(p => p.ProductImages)
                .FirstOrDefaultAsync(p => p.Id == productId);

            if (product == null)
            {
                return NotFound();
            }

            var imageUrls = product.ProductImages.Select(img => new { imgUrl = "/multipleimages/" + img.FileName });

            return Ok(imageUrls);
        }
    }
}
