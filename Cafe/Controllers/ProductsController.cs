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
        public async Task<ActionResult> All()
        {
            var result = await new ProductBuilder(this.services).BuildAll();

            return Ok(result);
        }
    }
}
