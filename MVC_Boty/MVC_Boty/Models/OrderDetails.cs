namespace MVC_Boty.Models
{
    public class OrderDetails
    {
        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public float Price { get; set; }

        public float Discount { get; set; }


        public Orders Order { get; set; }
        public Products Product { get; set; }
    }
}
