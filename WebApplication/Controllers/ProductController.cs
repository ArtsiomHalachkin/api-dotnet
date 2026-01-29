using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;
using WebApplication.DTOs;


namespace WebApplication.Controllers
{

    public class ProductController : ControllerBase
    {
        [Route("api/[controller]")]
        [HttpGet]
        public IActionResult GetProduct()
        {
          
            var product = new Product
            {
                Id = 1,
                Name = "Coffee",
                Price = 5.99m,
                InternalSecretCode = "X-123"
            };

   
            var productDto = new ProductDto
            {
                Name = product.Name,
                Price = product.Price
            };

            return Ok(productDto);
        }
    }
}
