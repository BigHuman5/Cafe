using AutoMapper;
using Cafe.BLL.DTO;
using Cafe.BLL.Interfaces;
using Cafe.BLL.Services;
using Cafe.Models.IngredientsInProducts;

namespace Cafe.Models.Products
{
    public class ProductBuilder
    {
        private IProductsServices services;

        public ProductBuilder(IProductsServices services)
        {
            this.services = services;
        }

        public async Task<List<ProductsShortResponseModel>> BuildAllShort()
        {
            IEnumerable<ProductsDTO> productsDTO = await services.All();
            var mapper = new MapperConfiguration(
                cfg => cfg.CreateMap<ProductsDTO, ProductsShortResponseModel>())
                .CreateMapper();
            var productsResponseModels = mapper
                .Map<IEnumerable<ProductsDTO>, List<ProductsShortResponseModel>>
                (productsDTO);
            return productsResponseModels;
        }

        public async Task<List<ProductsInDetailsResponseModel>> BuildAllInDetails()
        {
            List<ProductsDTO> all = await services.All();
            List<ProductsInDetailsResponseModel> CRM = new List<ProductsInDetailsResponseModel>();
            foreach (var item in all)
            {
                ProductsInDetailsResponseModel responseModel = new ProductsInDetailsResponseModel
                {
                    Id = item.Id,
                    Name = item.Name,
                    Description = item.Description,
                    Price = item.Price,
                    IngredientsInProductsResponse = new IngredientsInProductsResponseModel()
                    {
                        Id= item.Id,
                        
                    }
                };
                CRM.Add(responseModel);
            }
            return CRM;
        }
    
    }
}
