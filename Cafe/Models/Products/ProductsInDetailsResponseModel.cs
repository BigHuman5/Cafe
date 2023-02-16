using Cafe.Models.IngredientsInProducts;
using Cafe.Models.GroupProducts;

namespace Cafe.Models.Products
{
    public class ProductsInDetailsResponseModel
    {
        public int Id { get; set; }

        public GroupProductsResponseModel Group { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }

        public IngredientsInProductsResponseModel IngredientsInProductsResponse { get; set; }
    }
}
