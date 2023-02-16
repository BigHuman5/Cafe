using Cafe.DAL.Entities;


namespace Cafe.BLL.DTO
{
    public class IngredientsDTO : BaseDTO
    {
        public int Id { get; set; }

        public GroupProducts? GroupProduct { get; set; }

        public int? GroupProductId { get; set; }

        public string Name { get; set; } = "";
    }
}
