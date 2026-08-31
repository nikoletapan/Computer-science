using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_exercise_27._10._25
{
    public class Recursions
    {
        public int Factorial(int f)
        {
            if (f <= 1) return 1;
            return f * Factorial(f - 1);
        }
        public double Power(int a, int b)
        {
            if (b == 0) return 1;
            if (b == 1) return a;
            return a * Power(a, b - 1);
        }
        public static void Crash() 
        {
            Crash();
        }
    }
}
