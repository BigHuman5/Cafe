using Cafe.BLL.DTO;

namespace Cafe.BLL.Interfaces
{
    public interface IIngredientsInProductsServices
    {
        Task<List<IngredientsInProductsDTO>> All();
    }
}
