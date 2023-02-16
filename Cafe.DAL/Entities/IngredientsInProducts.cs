using System.ComponentModel.DataAnnotations;

namespace Cafe.DAL.Entities
{
    public class IngredientsInProducts : Base
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Ingredients Ingredient { get; set; }
        public int IngredientId { get; set; }
        [Required]
        public Products Product { get; set; }
        public int ProductId { get; set; }
    }
}
