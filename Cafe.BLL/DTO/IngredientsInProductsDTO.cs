using Cafe.DAL.Entities;


namespace Cafe.BLL.DTO
{
    public class IngredientsInProductsDTO
    {
        public int Id { get; set; }
        public Ingredients Ingredient { get; set; }
        public int IngredientId { get; set; }
        public Products Product { get; set; }
        public int ProductId { get; set; }
    }
}
