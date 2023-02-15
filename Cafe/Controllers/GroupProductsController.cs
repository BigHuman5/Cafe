using Cafe.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Cafe.Models.GroupProducts;


namespace Cafe.Controllers
{
    public class GroupProductsController : ApiController
    {
        IGroupProductsServices services;

        public GroupProductsController(IGroupProductsServices services)
        {
            this.services = services;
        }

        [HttpGet]
        public async Task<ActionResult> All()
        {
            var result = await new GroupProductBuilder(this.services).BuildAll();
            
            return Ok(result);
        }
    }
}
