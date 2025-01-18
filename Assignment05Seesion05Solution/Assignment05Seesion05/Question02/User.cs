using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05Seesion05.Question02
{
     class User
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
        public User(string userName , string password , string role)
        {
            Username = userName;
            Password = password;
            Role = role;
        }
    }
}
