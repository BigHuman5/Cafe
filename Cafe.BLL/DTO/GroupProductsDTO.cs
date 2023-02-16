using Cafe.DAL.Entities;


namespace Cafe.BLL.DTO
{
    public class GroupProductsDTO : BaseDTO
    {
        public int Id { get; set; }
        //[Required]
        public string Name { get; set; }

        public bool isDelete { get; set; }

        public List<Products> products { get; set; } = new List<Products>();
    }
}
