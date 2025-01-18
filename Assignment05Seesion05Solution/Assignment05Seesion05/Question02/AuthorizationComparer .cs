using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05Seesion05.Question02
{
    internal class AuthorizationComparer : IComparer<User>
    {
        string userName;
        string role;
        public AuthorizationComparer(string _userName ,  string _role )
        {
            this.userName = _userName;
            this.role = _role;
        }
        public int Compare(User? x, User? y)
        {
            if (x is null) return -1;
            if (x.Username == userName && x.Role == role)
            {
                return 0;
            }

            return -1;
        }
    }
}
