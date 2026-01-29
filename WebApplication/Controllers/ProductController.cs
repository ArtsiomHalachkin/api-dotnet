using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication.Data;
using WebApplication.DTOs;
using WebApplication.Models;


namespace WebApplication.Controllers
{

    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("api/[controller]")]
        [HttpGet]
        public async Task<IActionResult> GetProduct()
        {

            var products =  await _context.Products.ToListAsync();


            return Ok(products);
        }
    }
}
