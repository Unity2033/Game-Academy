using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Persistence
{
    List<User> users = new List<User>();

    public void Save(User user)
    {
        users.Add(user);
    }
    
    public User Find(string email)
    {
        foreach(User user in users)
        {
           if(user.Email == email)
           {
              return user;
           }
        }

        return null;
    }

    public bool Exists(string email)
    {
        foreach(User user in users) 
        {
            if (user.Email == email)
            {
                return true;
            }
        }

        return false;
    }
}

