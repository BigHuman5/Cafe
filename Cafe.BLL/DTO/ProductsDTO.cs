using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.BLL.DTO
{
    public class ProductsDTO
    {
        public int Id { get; set; }

        [Required]
        public GroupProductsDTO Group { get; set; }

        public int GroupId { get; set; }

        [Required]
        [MaxLength(40)]
        public string Name { get; set; } = "";

        [MaxLength(100)]
        public string Description { get; set; } = "";

        [Required]
        [MaxLength(5)]
        public int Price { get; set; } = 0;

        public bool isDeleted { get; set; } = false;
    }
}
