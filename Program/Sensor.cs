using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Sensor
    {
        public void Detect(Product product)
        {
            Console.WriteLine("It has been Detected");

            product.Describe();
        }
    }
}
