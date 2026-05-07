using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal abstract class Weapon
    {
        protected int range;
        protected int damage;

        public abstract void Attack();
    }
}
