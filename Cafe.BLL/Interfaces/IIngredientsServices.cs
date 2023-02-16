using Cafe.BLL.DTO;

namespace Cafe.BLL.Interfaces
{
    public interface IIngredientsServices
    {
        Task<List<IngredientsDTO>> All();
    }
}
