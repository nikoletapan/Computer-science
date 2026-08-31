using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3
{
    class ClothingItem
    {
        private readonly string storeName = "\"Fashion Boutique\""; // постоянно поле
        private string label;
        private string size;
        private string material;
        private double price;
        private int quantity;
        private bool onSale;

        public string Label
        {
            get { return label; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Етикетът не може да бъде празен!");
                label = value;
            }
        }

        public string Size
        {
            get { return size; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Размерът не може да бъде празен!");
                size = value;
            }
        }

        public string Material
        {
            get { return material; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Split(' ').Length < 2)
                    throw new ArgumentException("Материята трябва да съдържа поне 2 думи!");
                material = value;
            }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Цената трябва да бъде положително число!");
                price = value;
            }
        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Броят не може да бъде отрицателен!");
                quantity = value;
            }
        }

        public bool OnSale
        {
            get { return onSale; }
            set { onSale = value; }
        }

        public ClothingItem(string label, string size, string material, double price, int quantity, bool onSale)
        {
            Label = label;
            Size = size;
            Material = material;
            Price = price;
            Quantity = quantity;
            OnSale = onSale;
        }

         public double TotalPrice()
        {
            return Math.Round(price * quantity, 2);
        }

        public void PrintInfo()
        {
            Console.WriteLine($"._.♥._.♥. {storeName} .♥._.♥._.");
            Console.WriteLine($"Етикет: {label}");
            Console.WriteLine($"Размер: {size}");
            Console.WriteLine($"Материя: {material}");
            Console.WriteLine($"Цена: {price:F2} лв.");
            Console.WriteLine($"Бройки: {quantity}");
            Console.WriteLine($"Разпродажба: {(onSale ? "Да" : "Не")}");
            Console.WriteLine($"Обща стойност: {TotalPrice():F2} лв.");
            Console.WriteLine(".°._.°._.°._.°._.°._.°._.°._.°._.°._.°.");
        }
    }
}
