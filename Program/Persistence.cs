using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Persistence
    {
        List<User> users = new List<User>();

        public void Save(User user)
        {
            users.Add(user);
        }
    }
}
