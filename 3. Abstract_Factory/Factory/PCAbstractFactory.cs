using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._Abstract_Factory.Factory
{
    public class PCAbstractFactory
    {
        public static IFactory? createFactory(string osName)
        {
            if (osName == "Mac") 
            {
                return new MacFactory();
            }
            if (osName == "Windows")
            {
                return new WindowsFactory();
            }
            else
            {
                return null;
            }
        }
    }
}
