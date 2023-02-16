using Cafe.BLL.DTO;
using Cafe.BLL.Interfaces;
using Cafe.DAL.EF;
using Cafe.DAL.Entities;
using Cafe.Infrastructure.services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.BLL.Services
{
    public class GroupProductsServices : IGroupProductsServices
    {

        private readonly CafeDbContext data;
        public GroupProductsServices(CafeDbContext data)
        {
            this.data = data;
        }

        /// <summary>
        /// Получение списка всех категорий.
        /// </summary>
        /// <returns></returns>
        public async Task<List<GroupProductsDTO>> All()
        {
            var GroupProductsDTO = await data.GroupProducts
                .Where(p => !p.isDeleted)
                .OrderBy(i=>i.Id)
                .ToListAsync();

            List<GroupProductsDTO> result = new List<GroupProductsDTO>();

            foreach (var e in GroupProductsDTO)
            {
                GroupProductsDTO groupProductsDTO = new GroupProductsDTO()
                {
                    Id=e.Id,
                    Name=e.Name,
                };
                result.Add(groupProductsDTO);
            }
            return result;
        }
    }
}
