using _3._Abstract_Factory.Desktop;
using _3._Abstract_Factory.Laptop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._Abstract_Factory.Factory
{
    public interface IFactory
    {
        ILaptop createLaptop();
        IDesktop createDesktop();
    }
}
