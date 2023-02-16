using Cafe.BLL.Interfaces;
using Cafe.Models.Ingredients;
using Cafe.Models.Products;
using Microsoft.AspNetCore.Mvc;

namespace Cafe.Controllers
{
    public class IngredientsController : ApiController
    {
        private readonly IIngredientsServices services;

        public IngredientsController(IIngredientsServices services)
        {
            this.services = services;
        }

        [HttpGet]
        public async Task<ActionResult> All()
        {
            var result = await new IngredientsBuilder(services).BuildAll();

            return Ok(result);
        }
    }
}
