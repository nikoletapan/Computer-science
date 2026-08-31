using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_exercise_27._10._25
{
    internal class Account
    {
        private string accountNumber;
        private double balance;

        public string AccountNumber
        {
            get => accountNumber; 
            set { if(string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Грешка: Номерът на акаунта не може да има интервали!");
                if (value.Length <= 5)
                    throw new ArgumentException("Грешка: Номерът трябва да бъде поне 5 символа!");
                accountNumber = value; }
        }

        public double Balance
        {
            get => balance;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Грешка: Сметката не може да е негативна!");
                balance = Math.Round(value,2);
            }
        }

        public Account(string accountNumber, double balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Номер на акаунт: {AccountNumber}");
            Console.WriteLine($"Баланс: {Balance}");
            Console.WriteLine(new string("-"), 30);
        }
    }
}
