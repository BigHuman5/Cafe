using Cafe.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.BLL.Interfaces
{
    public interface IIngredientsServices
    {
        Task<List<IngredientsDTO>> All();
    }
}
