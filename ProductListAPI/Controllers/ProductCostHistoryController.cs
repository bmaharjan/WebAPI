using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProductListAPI.Models;
using System.Linq;

namespace ProductListAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCostHistoryController : ControllerBase
    {
        private readonly ProductContext _contextCH;

        public ProductCostHistoryController(ProductContext context) => _contextCH = context;

        //GET: api/productcosthistory/id
        [HttpGet("{id}")]
        public IQueryable<ProductCostHistory> GetProductCostHistoryItem(int id)
        {
            var productcosthistoryItem = _contextCH.ProductCostHistory.Where(s => s.ProductID == id);
            return productcosthistoryItem;
        }

        ////GET: api/productcosthistory
        //[HttpGet]
        //public ActionResult<IEnumerable<ProductCostHistory>> GetProductCostHistory()
        //{
        //    return _contextCH.ProductCostHistory;
        //}
    }
}