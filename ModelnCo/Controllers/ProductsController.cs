using Microsoft.AspNetCore.Http;
using ModelnCoAPI.Data;
using Microsoft.AspNetCore.Mvc;
using ModelnCoAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace ModelnCoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController(ModelnCoContext context) : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            return await context.Products.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProducts(int id)
        {
            var product = await context.Products.FindAsync(id);

            if(product == null) return NotFound();

            return product;
        }
    }
}
