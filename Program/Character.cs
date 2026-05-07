using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Character
    {
        private int currentCount;
        private List<Weapon> weapons;

        public Character() 
        {
            currentCount = 0;
            weapons = new List<Weapon>();
        }

        public void Acquire(Weapon weapon)
        {
            weapons.Add(weapon);
        }

        public void Swap()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKey key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.Spacebar)
                {
                    currentCount = currentCount + 1;

                    if( weapons.Count <= currentCount) 
                    {
                        currentCount = 0;
                    }                                   
                }
            }
        }

        public void Use()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKey key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.A)
                {
                    weapons[currentCount].Attack();
                }
            }
        }
    }
}
