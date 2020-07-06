using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProductListAPI.Models;

namespace ProductListAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductListController : ControllerBase
    {
        private readonly ProductContext _context;

        public ProductListController(ProductContext context) => _context = context;

        //GET: api/products
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            return _context.Product;
        }

        //GET: api/products/id
        [HttpGet("{id}")]
        public ActionResult<Product> GetProductItem(int id)
        {
            var productItem = _context.Product.Find(id);

            if(productItem == null)
            {
                return NotFound();
            }
            return productItem;
        }
    }
}