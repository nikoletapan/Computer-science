
namespace ChristmasWorkshop
    {
    class Program
    {
        static void Main(string[] args)
        {
            DisplayTitle();
            List<Gift> gifts = InitializeGifts();
            gifts.Add(new SweetGift("Щолен", 18.40, 1.2));

            List<Dwarf> dwarves = InitializeDwarves();
            dwarves.Add(new Dwarf("Знайко", "Книги"));

            DisplayAllGifts(gifts);

            Console.WriteLine("\n");
            AnalyzeGifts(gifts);

            Console.WriteLine("\n");
            FilterGiftsByType(gifts, "Играчка");

            Console.WriteLine("\n");
            FilterGiftsByType(gifts, "Книга");

            Console.WriteLine("\n");
            FilterGiftsByType(gifts, "Сладкиш");

            Console.WriteLine("\n");
            DisplayStatistics(gifts, dwarves);

            Console.WriteLine("\nКоледната работилница е готова! Весела Коледа!");
            Console.ReadKey();
        }

        private static void DisplayTitle()
        {
            Console.WriteLine("╔~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~╗");
            Console.WriteLine("{           Коледни подаръци          }");
            Console.WriteLine("╚~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~╝");
        }

        static List<Gift> InitializeGifts()
        {
            return new List<Gift>
            {
                new ToyGift("Кукла", 15.50, false),
                new ToyGift("Кола с дистанционо", 45.75, true),
                new ToyGift("Конструктор", 32.00, false),
                new BookGift("Златни приказки", 12.30, 120),
                new BookGift("Енциклопедия", 28.50, 350),
                new SweetGift("Меденки", 6.25, 0.3),
            };
        }

        static List<Dwarf> InitializeDwarves()
        {
            return new List<Dwarf>
            {
                new Dwarf("Веселушко", "Играчки"),
                new Dwarf("Сънливко", "Книги"),
                new Dwarf("Торбичка", "Сладкиши"),
                new Dwarf("Мърморко", "Книги"),
                new Dwarf("Щастливко", "Сладкиши"),
            };
        }
        static void DisplayAllGifts(List<Gift> gifts)
        {
            Console.WriteLine("=== ВСИЧКИ ПОДАРЪЦИ ===");
            foreach (var gift in gifts)
            {
                gift.DisplayInfo();
            }
        }

        static void AnalyzeGifts(List<Gift> gifts)
        {
            Console.WriteLine("=== АНАЛИЗ НА ПОДАРЪЦИТЕ ===");

            var mostExpensive = gifts.MaxBy(g => g.GetProductionCost());
            Console.WriteLine($"Най-скъп подарък: {mostExpensive.Name} ({mostExpensive.GetProductionCost():F2} златни монети)");

            var averageCost = gifts.Average(g => g.GetProductionCost());
            Console.WriteLine($"Средна себестойност: {averageCost:F2} златни монети");

            var totalCost = gifts.Sum(g => g.GetProductionCost());
            Console.WriteLine($"Обща себестойност: {totalCost:F2} златни монети");

            var giftsByType = gifts.GroupBy(g => g.GetGiftType());

            foreach (var group in giftsByType)
            {
                Console.WriteLine($"\n--- {group.Key} ---");
                Console.WriteLine($"Брой: {group.Count()}");
                Console.WriteLine($"Обща стойност: {group.Sum(g => g.GetProductionCost()):F2} златни монети");
                Console.WriteLine($"Средно време за производство: {group.Average(g => g.CalculateProductionTime()):F2} часа");
            }
        }

        static void FilterGiftsByType(List<Gift> gifts, string type)
        {
            Console.WriteLine($"=== ПОДАРЪЦИ ОТ ТИП: {type} ===");

            var filteredGifts = gifts.Where(g => g.GetGiftType() == type).ToList();

            if (!filteredGifts.Any())
            {
                Console.WriteLine($"Няма подаръци от тип '{type}'");
                return;
            }

            foreach (var gift in filteredGifts)
            {
                gift.DisplayInfo();
            }

            Console.WriteLine($"Общо {filteredGifts.Count} подаръка от този тип");
        }

        static void DisplayStatistics(List<Gift> gifts, List<Dwarf> dwarves)
        {
            Console.WriteLine("=== КОЛЕДНА СТАТИСТИКА ===");
            Console.WriteLine($"Общ брой подаръци: {Gift.TotalGiftsCount}");
            Console.WriteLine($"Общ брой джуджета: {Dwarf.TotalDwarves}");
            Console.WriteLine($"Средно подаръци на джудже: {(double)Gift.TotalGiftsCount / Dwarf.TotalDwarves:F1}");

            Console.WriteLine("\n--- Джуджета в работилницата ---");
            foreach (var dwarf in dwarves)
            {
                dwarf.DisplayInfo();
            }
        }

    }
    public abstract class Gift
        {
            public string Name { get; set; }
            private protected double productionCost; // private internal поле
            public static int TotalGiftsCount { get; private set; } = 0; // статична променлива

            // Конструктор
            protected Gift(string name, double cost)
            {
                Name = name;
                productionCost = cost;
                TotalGiftsCount++;
            }

            // Абстрактен метод
            public abstract double CalculateProductionTime();

            // Виртуален метод
            public virtual string GetGiftType()
            {
                return "Общ подарък";
            }

            // Обикновен метод за отпечатване
            public void DisplayInfo()
            {
                Console.WriteLine($"Подарък: {Name}");
                Console.WriteLine($"Тип: {GetGiftType()}");
                Console.WriteLine($"Себестойност: {productionCost:F2} златни монети");
                Console.WriteLine($"Време за производство: {CalculateProductionTime():F2} часа");
                Console.WriteLine(new string('-', 40));
            }

            public double GetProductionCost() => productionCost;
        }

        public class ToyGift : Gift
        {
            public bool HasBatteries { get; set; }

            public ToyGift(string name, double cost, bool hasBatteries) : base(name, cost)
            {
                HasBatteries = hasBatteries;
            }

            public override double CalculateProductionTime()
            {
                double baseTime = productionCost * 0.5;
                return HasBatteries ? baseTime + 1.0 : baseTime;
            }

            public override string GetGiftType()
            {
                return "Играчка";
            }
        }

        public class BookGift : Gift
        {
            public int PageCount { get; set; }

            public BookGift(string name, double cost, int pageCount) : base(name, cost)
            {
                PageCount = pageCount;
            }

            public override double CalculateProductionTime()
            {
                return productionCost * 0.3 + PageCount * 0.01;
            }

            public override string GetGiftType()
            {
                return "Книга";
            }
        }

        public class SweetGift : Gift
        {
            public double Weight { get; set; } // в кг

            public SweetGift(string name, double cost, double weight) : base(name, cost)
            {
                Weight = weight;
            }

            public override double CalculateProductionTime()
            {
                return productionCost * 0.2 + Weight * 0.5;
            }

            public override string GetGiftType()
            {
                return "Сладкиш";
            }
        }

        public class Dwarf
        {
            public string Name { get; set; }
            public string Specialty { get; set; }
            public static int TotalDwarves { get; private set; } = 0; // статична променлива

            public Dwarf(string name, string specialty)
            {
                Name = name;
                Specialty = specialty;
                TotalDwarves++;
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Джудже: {Name}");
                Console.WriteLine($"Специалност: {Specialty}");
                Console.WriteLine(new string('-', 40));
            }
        }
    }
