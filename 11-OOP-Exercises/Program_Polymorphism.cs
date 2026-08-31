using System.Diagnostics;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building b1 = new Building();           // РОДИТЕЛ
            Building b2 = new Building("бежов");
            Building b3 = new Building("читалище", "бежов", 1987);
            Console.WriteLine(new string('~', 33));

            House h1 = new House();                 // НАСЛЕДНИК 1
            House h2 = new House("къща", "охра", 1998, 3);
            Console.WriteLine(new string('~', 33));

            Apartment a1 = new Apartment();          // НАСЛЕДНИК 2
            Apartment a2 = new Apartment("апартамент", "зелен", 2004, true);
        }
    }
    public class Building
    {
        public string Type { get; set; }
        public string Color {  get; set; }
        public int Year { get; set; }

        public Building() => Console.WriteLine("Празен конструктор Building()"); // => съкратен запис вместо {}
        public Building(string color) 
        { 
            Type = "неизвестен";
            Color = color; 
            Console.WriteLine($"Типът на сградата е {Type}, цветът е {Color}, годината не е въведена."); 
        }
        public Building(string type, string color, int year) 
        { 
            Type = type; 
            Color = color; 
            Year = year; 
            Console.WriteLine($"Сградата е {Type}, цвят {Color}, година {Year} г."); 
        }
    }

    public class House : Building
    {
        public int Floors { get; set; }

        public House() => Console.WriteLine("Празен конструктор House()");  // : base() в случая е излишно
        public House(string type, string color, int year, int floors) : base(type, color, year)
        {
            Floors = floors;
            Console.WriteLine($"Къщата е с пълни характеристики: цвят {Color}, година {Year} г., етажи {Floors}");
        }
    }

    public class Apartment : Building
    {
        public bool Terraces { get; set; }

        public Apartment() : base() { Console.WriteLine("Празен конструктор Apartment()"); }
        public Apartment(string type, string color, int year, bool terraces) : base(type, color, year)
        {
            Terraces = terraces;
            Console.WriteLine($"Пълни данни за {Type}: {Color}, {Year} г., " + ( Terraces ? "има ": "няма ") + "тераси.");
        }
    }

}
