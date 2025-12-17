namespace MVC_Boty.Models
{
    public class Categories
    {
        public int Id { get; set; }

        public int ParentId { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }


        public ICollection<Products> Products { get; set; }
        public ICollection<Categories> ParentCategories { get; set; }

        public Categories Category { get; set; }
    }
}
