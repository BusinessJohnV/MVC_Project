namespace MVC_Boty.Models
{
    public class Orders
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


        public ICollection<OrderDetails> OrderDetails { get; set; }
        public Accounts Account { get; set; }
    }
}
