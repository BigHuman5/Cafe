using Cafe.BLL.Interfaces;
using Cafe.Models.Products;
using Microsoft.AspNetCore.Mvc;

namespace Cafe.Controllers
{
    public class ProductsController : ApiController
    {
        IProductsServices services;

        public ProductsController(IProductsServices services)
        {
            this.services = services;
        }

        [HttpGet]
        public async Task<ActionResult> AllShort()
        {
            var result = await new ProductBuilder(this.services).BuildAllShort();

            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult> AllInDetails()
        {
            var result = await new ProductBuilder(this.services).BuildAllInDetails();

            return Ok(result);
        }
    }
}
