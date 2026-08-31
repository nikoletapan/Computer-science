using Accessibility;

namespace Accessibility2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount b1 = new BankAccount();
            Console.WriteLine(b1.AccountNumber); //123
            b1.Deposit(200M);

            SavingsAccount s1 = new SavingsAccount();
            s1.TestAccess();
            Console.WriteLine(s1.AccountNumber); //234
            InternationalSavingsAccount i1 = new InternationalSavingsAccount();
            i1.TestAccess();
            Console.WriteLine(i1.AccountNumber); //456
        }
    }
}
