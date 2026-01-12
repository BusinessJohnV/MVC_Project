namespace MVC_Boty.Models
{
    public class AccountModel
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public Country Country { get; set; }
    }
}
