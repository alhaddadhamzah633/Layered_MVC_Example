namespace MVC_Example.DataAccessLayer.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
