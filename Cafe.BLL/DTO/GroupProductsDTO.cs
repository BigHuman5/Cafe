using Cafe.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.BLL.DTO
{
    public class GroupProductsDTO
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public bool isDelete { get; set; }

        public List<Products> products { get; set; } = new List<Products>();
    }
}
