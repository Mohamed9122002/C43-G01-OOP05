using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05Seesion05.Question02
{
    internal class AuthenticationComparer : IComparer<User>
    {
      
            string username;
            string password;
        
        public AuthenticationComparer(string _username ,string _password )
        {
            this.username = _username;
            this.password = _password;
        }
       
        public int Compare(User? x, User? y)
        {
            if (x is null)
            {
                return -1;
            }
            // username = "Abod"
            if (x.Username == username && x.Password == password )
            {
                return 0;
            }

            return -1;
        }
    }
}
