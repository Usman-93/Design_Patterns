using _1._Simple_Factory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._Simple_Factory.BankAccounts
{
    public class OffsetAccount : IBankAccount
    {
        bool IBankAccount.sendMoney(IBankAccount account, int amount)
        {
            // The validation is not complete. But just added a condition
            if (amount > 0)
            {
                Console.WriteLine($"{this} account sent {amount} to {account}");
                return true;
            }
            return false;
        }
    }
}
