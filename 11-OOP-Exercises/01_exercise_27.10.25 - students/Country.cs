using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _01_exercise_27._10._25
{
    public class Country
    {
        private string name = Console.ReadLine();  // private field
        private string capital = "София";
        private int population = 6000000;
        private int area = 111000;
        private double frequency;

        public void Frequency() // виждаме private чрез междинен public
        {
            frequency = (double)population / (double)area;
            Console.WriteLine($"Държава: {name} | Столица: {capital} | Население: {population} | Площ: {area} | Гъстота: {frequency:F4}\n ");
        }
    }
}
