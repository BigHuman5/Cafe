using Cafe.BLL.DTO;

namespace Cafe.BLL.Interfaces
{
    public interface IProductsServices
    {
        Task<List<ProductsDTO>> All();
    }
}
