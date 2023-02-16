using AutoMapper;
using Cafe.BLL.DTO;
using Cafe.BLL.Interfaces;

namespace Cafe.Models.Ingredients
{
    public class IngredientsBuilder
    {
        private readonly IIngredientsServices services;

        public IngredientsBuilder(IIngredientsServices services)
        {
            this.services = services;
        }

        public async Task<List<IngredientsResponseModel>> BuildAll()
        {
            IEnumerable<IngredientsDTO> ingredientsDTO = await services.All();
            var mapper = new MapperConfiguration(
                cfg => cfg.CreateMap<IngredientsDTO, IngredientsResponseModel>())
                .CreateMapper();
            var ingredientsResponseModel = mapper
                .Map<IEnumerable<IngredientsDTO>, List<IngredientsResponseModel>>
                (ingredientsDTO);
            return ingredientsResponseModel;
        }
    }
}
