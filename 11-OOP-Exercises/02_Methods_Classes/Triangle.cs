using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Methods_Classes
{
    public class Triangle
    {
        private string name;
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(string name, double sideA, double sideB, double sideC)
        {
            this.name = name;
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public double Perimeter()
        { return sideA + sideB + sideC; }

        public double Area() 
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p*(p-sideA)*(p-sideB)*(p-sideC));
        }
    }

}
