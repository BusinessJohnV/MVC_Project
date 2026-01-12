namespace MVC_Boty.Models
{
    public class CategoriesModel
    {
        public int Id { get; set; }

        public int ParentId { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }
    }
}
