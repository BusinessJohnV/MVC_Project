namespace MVC_Boty.Models
{
    public class Storage
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public string Color { get; set; }

        public int Size { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }


        public Products Product { get; set; }
    }
}
