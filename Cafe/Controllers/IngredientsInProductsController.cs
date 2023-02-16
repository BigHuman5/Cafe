using Cafe.BLL.Interfaces;
using Cafe.Models.Ingredients;
using Cafe.Models.IngredientsInProducts;
using Cafe.Models.Products;
using Microsoft.AspNetCore.Mvc;

namespace Cafe.Controllers
{
    public class IngredientsInProductsController : ApiController
    {
        private readonly IIngredientsInProductsServices services;

        public IngredientsInProductsController(IIngredientsInProductsServices services)
        {
            this.services = services;
        }

        [HttpGet]
        public async Task<ActionResult> All()
        {
            var result = await new IngredientsInProductsBuilder(services).BuildAll();

            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult> CompositionProduct(int id)
        {
            var result = await new IngredientsInProductsBuilder(services).Composition(id);
            return Ok(result);
        }
    }
}
