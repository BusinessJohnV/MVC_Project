using System.Drawing;

namespace MVC_Boty.Models
{
    public class ViewModel
    {
        public List<Accounts> accounts { get; set; }

        public List<Categories> categories { get; set; }

        public List<OrderDetails> orderDetails { get; set; }

        public List<Orders> orders { get; set; }

        public List<ProductDetails> productDetails { get; set; }

        public List<Products> products { get; set; }
    }
}
