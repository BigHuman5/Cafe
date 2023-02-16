using Cafe.BLL.DTO;
using Cafe.BLL.Interfaces;
using Cafe.DAL.EF;
using Microsoft.EntityFrameworkCore;

namespace Cafe.BLL.Services
{
    public class IngredientsServices : IIngredientsServices
    {
        private readonly CafeDbContext data;

        public IngredientsServices(CafeDbContext data)
        {
            this.data = data;
        }

        public async Task<List<IngredientsDTO>> All()
        {
            var IngredientsDTO = await data.Ingredients
                .Where(p => !p.isDeleted)
                .OrderBy(i => i.Id)
                .ToListAsync();

            List<IngredientsDTO> resultList = new List<IngredientsDTO>();

            foreach (var e in IngredientsDTO)
            {
                IngredientsDTO Ingredients = new IngredientsDTO()
                {
                    Id = e.Id,
                    Name = e.Name,
                    GroupProductId= e.GroupProductId,
                };
                resultList.Add(Ingredients);
            }
            return resultList;
        }

    }
}
