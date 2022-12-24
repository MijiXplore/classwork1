using System.Reflection;

namespace WebApplication8.Models
{
    public class user
    {
        public string? name { get; set; }
        public string? email { get; set; }
        public string? password { get; set; }

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
