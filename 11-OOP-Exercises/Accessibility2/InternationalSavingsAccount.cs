using Accessibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessibility2
{
    public class InternationalSavingsAccount : BankAccount
    {
        public void TestAccess()
        {
            // balance - НЕ достъпен
            AccountNumber = "456";          // OK - public
            // BankName - НЕ достъпен (internal, друг проект)
            Withdraw(50);                   // OK - protected (винаги в наследник)
            Deposit(100);                   // OK - public
            CalculateInterest();            // OK - protected internal (защото е наследник)
            // Log("test"); - НЕ достъпен (private protected: най-защитен)            
        }
    }
}
