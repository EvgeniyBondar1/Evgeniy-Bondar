using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{

    public class LoginViewModel
    {
        //Range,Compare,Phone,CreditCard,EmailAddress

        [MaxLength(12)]//ограничение длины
        public string UserName { get; set; } = "";

        [MaxLength(12)]//ограничение длины
        public string Password { get; set; } = "";


        public LoginViewModel(string userName, string password)
        {
            this.UserName = userName;
            this.Password = password;

        }
        public LoginViewModel()
        {

        }
    }
}
