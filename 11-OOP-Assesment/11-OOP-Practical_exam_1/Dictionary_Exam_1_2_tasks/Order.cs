using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Bill
    {

        private Dictionary<char, decimal> menu;
        private decimal total;

        public Bill()
        {
            menu = new Dictionary<char, decimal>();
            total = 0.0m;

            InicializeMenu();
        }

        private void InicializeMenu()
        {
            menu.Add('D', 28.90m);
            menu.Add('C', 15.50m);
            menu.Add('T', 12.75m);
            menu.Add('A', 8.30m);
        }

        public void ShowMenu()
        {
            Console.WriteLine("=== MENU ===");
            Console.WriteLine("D) Dog food - 28.90lv");
            Console.WriteLine("C) Cat food - 15.50lv");
            Console.WriteLine("T) Toys - 12.75lv");
            Console.WriteLine("A) Accessories - 8.30lv");
            Console.WriteLine("Enter the letter for the item (or BILL if you are ready):");
        }

        public void Choices()
        {
            while (true)
            {
                Console.Write("> ");
                string input = Console.ReadLine().ToUpper();

                if (input == "BILL")
                    break;

                if (input.Length == 1 && menu.ContainsKey(input[0]))
                {
                    char item = input[0];
                    total += menu[item];
                    Console.WriteLine($"You added {item}. Your total for now is: {total:F2}lv");
                }
            }
        }

        public void ShowBill()
        {
            const decimal JPYRate = 0.012m;
            decimal totalJPY = total / JPYRate;

            Console.WriteLine("\n===== BILL =====");
            Console.WriteLine($"Total: {Math.Round(total, 2)}lv");
            Console.WriteLine($"Total in JPY: {Math.Round(totalJPY, 2)}JPY");
        }
    }
}
