using Cafe.DAL.Entities;


namespace Cafe.BLL.DTO
{
    public class IngredientsInProductsDTO : BaseDTO
    {
        public int Id { get; set; }
        public IngredientsDTO Ingredient { get; set; }
        public int IngredientId { get; set; }
        public ProductsDTO Product { get; set; }
        public int ProductId { get; set; }
    }
}
