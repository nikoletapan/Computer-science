using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_vs_new_object
{
    public class Country
    {
        private string name = Console.ReadLine();  // private field
        private string capital = "София";
        private int population = 6000000;
        private int area = 111000;
        private double frequency;

        public void Frequency()
        {
            frequency = (double)population / (double)area;
            Console.WriteLine($"Държава: {name} | Столица: {capital} | Население: {population} | Площ: {area} | Гъстота: {frequency}\n ");
        }
    }
}
