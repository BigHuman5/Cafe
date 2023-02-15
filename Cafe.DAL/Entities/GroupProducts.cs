using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.DAL.Entities
{
    public class GroupProducts
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = "";

        public bool isDeleted { get; set; } = false;

        public List<Products> products { get; set; } = new List<Products>();

    }
}
