using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessibility
{
    public class BankAccount // internal -> public
    {
        private decimal balance = 1000M;
        public string AccountNumber { get; set; } = "123";

        internal string BankName;
        protected void Withdraw(decimal amount) { balance -= amount; }
        public void Deposit(decimal amount) { balance += amount; }
        protected internal void CalculateInterest() { Console.WriteLine("Calculate interest."); }
        private protected void Log(string message) { Console.WriteLine(message); }
    }
}
