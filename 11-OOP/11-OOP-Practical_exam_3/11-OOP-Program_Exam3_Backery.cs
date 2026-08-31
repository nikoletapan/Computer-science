  internal class Program
    {
        static void Main()
        {
            Console.WriteLine("###### Практически изпит XI клас първи вариант ######");
                               
            try
            {
		Recipe r1 = new Recipe("Шоколадов мъфин", 25, "брашно, какао, захар, масло, яйца", 3.50M, 10, true);
                r1.PrintInfo();
                Recipe r2 = new Recipe("Чийзкейк", 45, "бисквити, масло, сирене, захар, сметана", 4.20M, 8, true);
                r2.PrintInfo();

                Console.WriteLine("Въведете данни за нова рецепта:");
                Console.Write("Име: ");
                string name = Console.ReadLine();
                Console.Write("Време за приготвяне: ");
                int time = int.Parse(Console.ReadLine());
                Console.Write("Продукти (разделени със запетая): ");
                string products = Console.ReadLine();
                Console.Write("Цена на порция: ");
                decimal price = decimal.Parse(Console.ReadLine());
                Console.Write("Брой порции: ");
                int qty = int.Parse(Console.ReadLine());
                Console.Write("Налична ли е (да/не): ");
                bool available = Console.ReadLine().Trim().ToLower() == "да";

                Recipe r3 = new Recipe(name, time, products, price, qty, available);

                r3.PrintInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.ReadKey();

        Console.WriteLine("###### Край! ######");

        }
    }

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

