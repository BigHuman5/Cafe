using Cafe.BLL.DTO;
using Cafe.Infrastructure.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.BLL.Interfaces
{
    public interface IGroupProductsServices
    {
        Task<List<GroupProductsDTO>> GetAll();
    }
}
