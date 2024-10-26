using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._Abstract_Factory.Desktop
{
    public class MacDesktop : IDesktop
    {
        public void turnOff()
        {
            Console.WriteLine($"Mac Desktop turned off");
        }

        public void turnOn()
        {
            Console.WriteLine($"Mac Desktop turned on");
        }
    }
}
