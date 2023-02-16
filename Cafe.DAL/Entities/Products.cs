using System.ComponentModel.DataAnnotations;

namespace Cafe.DAL.Entities
{
    public class Products : Base
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public GroupProducts Group { get; set; }

        public int? GroupId { get; set; }

        [Required]
        [MaxLength(40)]
        public string Name { get; set; } = "";

        [MaxLength(100)]
        public string Description { get; set; } = "";

        [Required]
        [MaxLength(5)]
        public int  Price { get; set; } = 0;

        public IEnumerable<IngredientsInProducts> Ingredients { get; set;}
    }
}
