using Cafe.BLL.DTO;
using Cafe.BLL.Interfaces;
using Cafe.DAL.EF;
using Microsoft.EntityFrameworkCore;

namespace Cafe.BLL.Services
{
    public class IngredientsInProductsServices : IIngredientsInProductsServices
    {
        private readonly CafeDbContext data;

        public IngredientsInProductsServices(CafeDbContext data)
        {
            this.data = data;
        }

        public async Task<List<IngredientsInProductsDTO>> All()
        {
            var ingredientsInProducts = await data.IngredientsInProducts
                .Where(p => !p.isDeleted)
                .OrderBy(i => i.Id)
                .ToListAsync();

            List<IngredientsInProductsDTO> resultList = new List<IngredientsInProductsDTO>();

            foreach (var e in ingredientsInProducts)
            {
                IngredientsInProductsDTO ingredientsInProductsDTO = new IngredientsInProductsDTO()
                {
                    Id = e.Id,
                    IngredientId= e.IngredientId,
                    ProductId= e.ProductId,
                };
                resultList.Add(ingredientsInProductsDTO);
            }
            return resultList;
        }
    }
}
