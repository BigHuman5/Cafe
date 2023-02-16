using AutoMapper;
using Cafe.BLL.DTO;
using Cafe.BLL.Interfaces;
using Cafe.BLL.Services;

namespace Cafe.Models.GroupProducts
{
    public class GroupProductBuilder
    {
        private IGroupProductsServices services;

        public GroupProductBuilder(IGroupProductsServices services)
        {
            this.services = services;
        }

        public async Task<List<GroupProductsResponseModel>> BuildAll()
        {
            IEnumerable<GroupProductsDTO> groupProductsDTO = await services.All();
            var mapper = new MapperConfiguration(
                cfg => cfg.CreateMap<GroupProductsDTO, GroupProductsResponseModel>())
                .CreateMapper();
            var groupProductsResponseModels = mapper
                .Map<IEnumerable<GroupProductsDTO>, List<GroupProductsResponseModel>>
                (groupProductsDTO);
            return groupProductsResponseModels;
        }
    }
}
