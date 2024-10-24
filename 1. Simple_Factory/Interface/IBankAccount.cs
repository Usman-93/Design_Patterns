using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._Simple_Factory.Interface
{
    public interface IBankAccount
    {
        bool sendMoney(IBankAccount account, int amount);

    }
}
