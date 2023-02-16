using System.ComponentModel.DataAnnotations;

namespace Cafe.DAL.Entities
{
    public class Ingredients : Base
    {
        [Key]
        public int Id { get; set; }

        public GroupProducts? GroupProduct { get; set; }

        public int? GroupProductId { get; set; }

        public string Name { get; set; } = "";

        public IEnumerable<IngredientsInProducts> IngredientsInProducts { get; set; }
    }
}
