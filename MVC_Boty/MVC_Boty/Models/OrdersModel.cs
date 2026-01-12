namespace MVC_Boty.Models
{
    public class OrdersModel
    {
        public int Id { get; set; }

        public int AccountId { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime? ShippingDate { get; set; }

        public string CustomerName { get; set; }

        public string CustomerAddress { get; set; }

        public string CustomerCity { get; set; }

        public CustomerRegion CustomerRegion { get; set; }

        public string CustomerPostcode { get; set; }

        public Country Country { get; set; }

        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public float Price { get; set; }

        public float Discount { get; set; }
    }
}
