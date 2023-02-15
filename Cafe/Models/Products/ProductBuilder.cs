using AutoMapper;
using Cafe.BLL.DTO;
using Cafe.BLL.Interfaces;
using Cafe.BLL.Services;

namespace Cafe.Models.Products
{
    public class ProductBuilder
    {
        private IProductsServices services;

        public ProductBuilder(IProductsServices services)
        {
            this.services = services;
        }

        public async Task<List<ProductsResponseModel>> BuildAll()
        {
            IEnumerable<ProductsDTO> productsDTO = await services.GetAll();
            var mapper = new MapperConfiguration(
                cfg => cfg.CreateMap<ProductsDTO, ProductsResponseModel>())
                .CreateMapper();
            var productsResponseModels = mapper
                .Map<IEnumerable<ProductsDTO>, List<ProductsResponseModel>>
                (productsDTO);
            return productsResponseModels;
        }
    }
}
