using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._Abstract_Factory.Laptop
{
    public class WindowsLatop : ILaptop
    {
        public void carryInBagPack()
        {
            Console.WriteLine($"Windows Laptop in Bag Pack");
        }

        public void turnOff()
        {
            Console.WriteLine($"Windows Laptop turned off");
        }

        public void turnOn()
        {
            Console.WriteLine($"Windows Laptop turned on");
        }
    }
}
