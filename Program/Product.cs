using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal abstract class Product
    {
        protected int price;
        protected string menuel;

        public void Describe()
        {
            Console.WriteLine("Price : " + price);
            Console.WriteLine("Menuel : " + menuel);

            Console.WriteLine();
        }
    }
}
