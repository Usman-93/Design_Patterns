using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._Abstract_Factory.Laptop
{
    public class MacLatop : ILaptop
    {
        public void carryInBagPack()
        {
            Console.WriteLine($"Mac Laptop in Bag Pack");
        }

        public void turnOff()
        {
            Console.WriteLine($"Mac Laptop turned off");
        }

        public void turnOn()
        {
            Console.WriteLine($"Mac Laptop turned on");
        }
    }
}
