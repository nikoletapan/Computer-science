using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Exam2_methods_array
{
    internal class Reverse
    {
        public static void Name() { 
        Console.Write("Enter text: ");
            char[] arr = Console.ReadLine().ToCharArray();
        Console.Write("Reversed text: ");
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                    Console.Write(arr[i]);
            }
        }
    }
}
