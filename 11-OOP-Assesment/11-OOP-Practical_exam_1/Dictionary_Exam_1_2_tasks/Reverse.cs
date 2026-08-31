using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 2 задача от изпитването 

namespace Dictionary
{
    internal class Reverse
    {
        public void Reversion()
        {
            Console.Write("Enter text: ");
            string input = Console.ReadLine();

            char[] letters = input.ToCharArray();

            Array.Reverse(letters);

            string reversed = new string(letters);
            Console.WriteLine("Reversed text: " + reversed);
        }
    }
}
