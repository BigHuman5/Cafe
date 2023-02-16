using Cafe.BLL.DTO;
using Cafe.BLL.Interfaces;
using Cafe.DAL.EF;
using Cafe.DAL.Entities;
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

        /// <summary>
        /// Получение списка ингредиентов в продуктах 
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Получение состава какого-либо продукта
        /// </summary>
        /// <param name="id">Номер продукта</param>
        /// <returns></returns>
        public async Task<List<IngredientsInProductsDTO>> Composition(int id)
        {
            var ingredientsInProducts = await data.IngredientsInProducts
                .Where(p => p.ProductId == id)
                .Include(p=>p.Ingredient)
                .Where(p => !p.isDeleted && !p.Ingredient.isDeleted)
                .OrderBy(o=>o.Id)
                .ToListAsync();

            List<IngredientsInProductsDTO> resultList = new List<IngredientsInProductsDTO>();

            foreach (var e in ingredientsInProducts)
            {
                IngredientsInProductsDTO ingredientsInProductsDTO = new IngredientsInProductsDTO()
                {
                    Ingredient = new IngredientsDTO()
                    {
                        Id = e.Id,
                        Name = e.Ingredient.Name
                    }
                };
                resultList.Add(ingredientsInProductsDTO);
            }
            return resultList;

        }
    }
}
