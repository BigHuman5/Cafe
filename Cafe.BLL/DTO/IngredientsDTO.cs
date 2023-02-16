using Cafe.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.BLL.DTO
{
    public class IngredientsDTO
    {
        public int Id { get; set; }

        public GroupProducts? GroupProduct { get; set; }

        public int? GroupProductId { get; set; }

        public string Name { get; set; } = "";
    }
}
