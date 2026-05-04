using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Authenticate
{
    private Persistence persistence;

    public Authenticate(Persistence persistence)
    {
        this.persistence = persistence;
    }

    public bool Execute(User user)
    {
        if(persistence.Find(user.Email) == null)
        {
            return false;
        }

        return true;
    }
}

