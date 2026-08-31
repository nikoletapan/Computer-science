using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3
{
    internal class Car
    {
        private readonly string dealershipName = "Авто свят";

        private string brand;
        private string description;
        private int year;
        private double price;
        private int quantity;
        public bool isInProduction;

        public string Brand
        {
            get { return brand; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Грешка: Марката не може да е празна!");
                brand = value;
            }
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (value.Length < 4)
                    throw new ArgumentException("Грешка: Описанието трябва да съдържа поне 4 думи!");
                description = value;
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value < 1885 || value > 2025)
                    throw new ArgumentException("Грешка: Годината на производство трябва да е между 1885 и 2025!");
                year = value;
            }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Грешка: Цената трябва да е положителна!");
                price = Math.Round(value, 2);
            }
        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Грешка: Броят налични автомобили не може да е отрицателен!");
                quantity = value;
            }
        }

        public bool IsInProduction
        {
            get { return isInProduction; }
            set { isInProduction = value; }
        }

        public Car(string brand, string description, int year, double price, int quantity, bool isInProduction)
        {
            Brand = brand;
            Description = description;
            Year = year;
            Price = price;
            Quantity = quantity;
            this.IsInProduction = isInProduction;
        }

        public double CalculateTotalValue()
        {
            return Math.Round(price * quantity, 2);
        }

        public void PrintInfo()
        {
            Console.WriteLine("========== АВТОМОБИЛ ==========");
            Console.WriteLine($"Автокъща: {dealershipName}");
            Console.WriteLine($"Марка: {Brand}");
            Console.WriteLine($"Описание: {Description}");
            Console.WriteLine($"Година на производство: {Year}");
            Console.WriteLine($"Цена: {Price:F2} лв.");
            Console.WriteLine($"Брой налични: {Quantity}");
            Console.WriteLine($"Обща стойност: {CalculateTotalValue():F2} лв.");
            Console.WriteLine($"Произвежда се: {(IsInProduction ? "Да" : "Не")}");
            Console.WriteLine("==============================");
        }
    }
}
