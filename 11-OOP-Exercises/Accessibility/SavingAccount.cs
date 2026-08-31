using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessibility
{
    public class SavingsAccount : BankAccount
    {
        public void TestAccess()
        {
            //balance - НЕ е достъпен (private)
            AccountNumber = "234";          // OK - public
            BankName = "MyBank";            // OK - internal (същия проект)
            Withdraw(50M);                  // OK - protected
            Deposit(100M);                  // OK - public
            CalculateInterest();            // OK - protected internal
            Log("test");                    // OK - private protected (същия проект)
        }
    }
}
