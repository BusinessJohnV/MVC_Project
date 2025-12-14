namespace MVC_Boty.Models
{
    public class Accounts
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public Country Country { get; set; }


        public ICollection<Orders> Orders { get; set; }
    }
}
