using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_exam_preparation1
{
    internal class Outside
    {
        public static void Add(int a)  
        {
            Internal();
            Console.WriteLine($"Това е метод Add, a+2 = {a+2}"); 
        }

        private static void Internal()
        {
            Console.WriteLine("Вложеният метод Internal, който е private");
        }
    }
}
