using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_exercise_27._10._25
{
    internal class Car
    {
        private string model;
        private string color;
        private int year;

        public string Model;
        public string Color;
        public int Year;
        public Car(string model, string color, int year) 
        {
            this.model = model; 
            this.color = color;
            this.year = year;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Колата е {model}, {color}, {year}");
        }
    }
}
