
namespace Cafe.BLL.DTO
{
    public class ProductsDTO : BaseDTO
    {
        public int Id { get; set; }

        //[Required]
        public GroupProductsDTO Group { get; set; }

        public int GroupId { get; set; }

        //[Required]
        //[MaxLength(40)]
        public string Name { get; set; } = "";

        //[MaxLength(100)]
        public string Description { get; set; } = "";

        //[Required]
        //[MaxLength(5)]
        public int Price { get; set; } = 0;

        public IngredientsInProductsDTO ingredients { get; set; }
    }
}
