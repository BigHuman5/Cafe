using Cafe.BLL.DTO;
using Cafe.BLL.Interfaces;
using Cafe.DAL.EF;
using Microsoft.EntityFrameworkCore;


namespace Cafe.BLL.Services
{
    public class ProductsServices : IProductsServices
    {

        private readonly CafeDbContext data;
        public ProductsServices(CafeDbContext data)
        {
            this.data = data;
        }
        /// <summary>
        /// Получения списках всех продутов.
        /// </summary>
        /// <returns></returns>
        public async Task<List<ProductsDTO>> GetAll()
        {
            var result = await data.Products.Join(data.GroupProducts,
                p => p.GroupId,
                g => g.Id,
                (p, g) => new
                {
                    Id = p.Id,                    
                    Group = new {
                        Id=g.Id,
                        isDeleted = g.isDeleted,
                    },
                    Name = p.Name,
                    Description = p.Description,
                    Price = p.Price,
                    isDeleted = p.isDeleted
                })
                .Where(p => !p.isDeleted && !p.Group.isDeleted)
                .OrderBy(p=>p.Id)
                .ToListAsync();

            List<ProductsDTO> resultList = new List<ProductsDTO>();

            foreach (var p in result)
            {
                ProductsDTO productsDTO = new ProductsDTO()
                {
                    Id= p.Id,
                    Name= p.Name,
                    GroupId=p.Group.Id,
                    Price= p.Price,
                    Description= p.Description,
                };
                resultList.Add(productsDTO);
            }

            return resultList;
        }
    }
}
