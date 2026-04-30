using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class User
    {
        private string email;
        private string password;

        public string Email { get { return email; } }

        public User(string email, string password)
        {
            this.email = email;
            this.password = password;
        }
    }
}
