using AutoMapper;
using Cafe.BLL.DTO;
using Cafe.BLL.Interfaces;

namespace Cafe.Models.IngredientsInProducts
{
    public class IngredientsInProductsBuilder
    {
        private IIngredientsInProductsServices services;

        public IngredientsInProductsBuilder(IIngredientsInProductsServices services)
        {
            this.services = services;
        }

        public async Task<List<IngredientsInProductsResponseModel>> BuildAll()
        {
            IEnumerable<IngredientsInProductsDTO> ingredientsInProductsDTO = await services.All();
            var mapper = new MapperConfiguration(
                cfg => cfg.CreateMap<IngredientsInProductsDTO, IngredientsInProductsResponseModel>())
                .CreateMapper();
            var ingredientsInProductResponseModels = mapper
                .Map<IEnumerable<IngredientsInProductsDTO>, List<IngredientsInProductsResponseModel>>
                (ingredientsInProductsDTO);
            return ingredientsInProductResponseModels;
        }

        public async Task<List<CompositionProductResponseModel>> Composition(int id)
        {
            var DTO = await services.Composition(id);
            List<CompositionProductResponseModel> modelList = new List<CompositionProductResponseModel>();
            foreach(var s in DTO)
            {
                CompositionProductResponseModel model = new()
                {
                    IdIngredients = s.Ingredient.Id,
                    Name = s.Ingredient.Name,
                };
                modelList.Add(model);
            }
            
            return modelList;
        }
    }
}
