using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Cafe.Models.Products
{
    public class ProductsResponseModel
    {
        public int Id { get; set; }

        public int GroupId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }
    }
}
