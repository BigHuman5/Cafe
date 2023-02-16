using System.ComponentModel.DataAnnotations;

namespace Cafe.DAL.Entities
{
    public class GroupProducts : Base
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = "";

        public IEnumerable<Products> Products { get; set; }
        public IEnumerable<Ingredients> Ingredients { get; set; }
    }
}
