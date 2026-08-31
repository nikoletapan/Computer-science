using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3
{
    internal class Recipe
    {
        private readonly string bakeryName = "\"Горската сладкарница\"";

        private string label;
        private int preparationTime;
        private string ingredients;
        private decimal pricePerPortion;
        private int portions;
        private bool isAvailable;

        public string Label
        {
            get { return label; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Грешка: Името на рецептата не може да е празно!");
                label = value;
            }
        }

        public int PreparationTime
        {
            get { return preparationTime; }
            set
            {
                if (value < 5 || value > 55)
                    throw new ArgumentException("Грешка: Времето за приготвяне трябва да е между 5 и 55 минути!");
                preparationTime = value;
            }
        }

        public string Ingredients
        {
            get { return ingredients; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Split(',', StringSplitOptions.RemoveEmptyEntries).Length < 4)
                    throw new ArgumentException("Трябва да въведете поне 4 продукта, разделени със запетая!");
                ingredients = value;
            }
        }

        public decimal PricePerPortion
        {
            get { return pricePerPortion; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Грешка: Цената трябва да е положителна!");
                pricePerPortion = Math.Round(value, 2);
            }
        }

        public int Portions
        {
            get { return portions; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Грешка: Броят порции трябва да е положителен!");
                portions = value;
            }
        }

        public bool IsAvailable
        {
            get { return isAvailable; }
            set { isAvailable = value; }
        }

        public Recipe(string label, int preparationTime, string ingredients, decimal pricePerPortion, int portions, bool isAvailable)
        {
            Label = label;
            PreparationTime = preparationTime;
            Ingredients = ingredients;
            PricePerPortion = pricePerPortion;
            Portions = portions;
            IsAvailable = isAvailable;
        }

        public decimal CalculateTotalPrice()
        {
            return Math.Round(pricePerPortion * portions, 2);
        }

        public void PrintInfo()
        {
            Console.WriteLine($@".-._.-._.-._.-._.-.РЕЦЕПТА .-._.-._.-._.-._.-.
Пекарна: {bakeryName}
Рецептата: {Label}
Време за приготвяне: {PreparationTime} мин
Продукти: {Ingredients}
Цена на порция: {PricePerPortion:F2} лв.
Порции: {Portions} бр.
Обща сума: {CalculateTotalPrice():F2} лв.
Налична: {(IsAvailable ? "Да" : "Не")}
.-._.-._.-._.-._.-..-._.-._.-._.-._.-._.-._.-.");
        }
    }
}
