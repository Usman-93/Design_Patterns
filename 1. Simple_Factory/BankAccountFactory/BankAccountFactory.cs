using _1._Simple_Factory.BankAccounts;
using _1._Simple_Factory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _1._Simple_Factory.BankAccountFactory
{
    public class BankAccountFactory
    {
        public static IBankAccount? createBankAccount(string accountType)
        {
            if (accountType == "OffsetAccount")
            {
                return new OffsetAccount();
            }
            else if (accountType == "SavingsAccount")
            {
                return new SavingsAccount();
            }
            else
            {
                return null;
                throw new Exception("Invalid Account Type");
            }


        }
    }
}
