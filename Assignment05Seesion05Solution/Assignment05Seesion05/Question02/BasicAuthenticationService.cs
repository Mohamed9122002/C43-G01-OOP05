using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05Seesion05.Question02
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        private readonly User[] users = new User[]
          {
            new User("Mohamed", "password123", "admin"),
            new User("user", "userpass", "User")
        };
        
        public bool AuthenticateUser(string username, string password)

        {
            // userName = Abdo 
            // password = 12345
            AuthenticationComparer compare = new AuthenticationComparer(username, password);
          foreach (User  user in users)
            {
                if (compare.Compare(user, user) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public bool AuthorizeUser(string username, string role)
        {
            AuthorizationComparer authorizationComparer = new AuthorizationComparer(username, role);

            foreach (User user in users)
            {
                if (authorizationComparer.Compare(user, user) == 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
