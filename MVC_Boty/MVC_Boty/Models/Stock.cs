namespace MVC_Boty.Models
{
    public class Stock
    {
        public int Id { get; set; }

        public int ProductDetailId { get; set; }

        public int Quantity { get; set; }

        public ProductDetails ProductDetail { get; set; }
    }
}
