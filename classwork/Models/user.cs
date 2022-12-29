using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace classwork.Models
{
    public class user
    {
        [Required]
        public string? name { get; set; }
        [Required]
        [EmailAddress]
        public string? email { get; set; }
        [Required]
        [PasswordPropertyText]
        public string? password { get; set; }
        [Compare("password", ErrorMessage = "Password doesn't match please type again !")]
        public string ConfirmPassword { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

        public string role { get; set; }

        public enum roles                                      //makes a list u can pick one of (drop down)
        {
            admin,
            customer
        }

        public user()      //constructor used to initialize variables
        {

        }
        //method overloading
        public user(string name, string email, string password, string role)
        {
            this.name = name;
            this.email = email;
            this.password = password;
            this.role = role;
        }
    }
}
