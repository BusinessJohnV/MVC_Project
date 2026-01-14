namespace MVC_Boty.Models
{
    public class ProductDetails
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public string Color { get; set; }

        public int Size { get; set; }

        public float Price { get; set; }

        public float Discount { get; set; }

        public string ImagePath { get; set; }


        public Products Product { get; set; }
    }
}
