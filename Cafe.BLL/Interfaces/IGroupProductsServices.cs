using Cafe.BLL.DTO;

namespace Cafe.BLL.Interfaces
{
    public interface IGroupProductsServices
    {
        Task<List<GroupProductsDTO>> All();
    }
}
