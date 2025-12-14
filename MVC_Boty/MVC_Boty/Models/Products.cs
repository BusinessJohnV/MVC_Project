namespace MVC_Boty.Models
{
    public class Products
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public string ProductName { get; set; }

        public string? Description { get; set; }


        public ICollection<OrderDetails> OrderDetails { get; set; }
        public ICollection<Storage> Storages { get; set; }
        public Categories Category { get; set; }
    }
}
