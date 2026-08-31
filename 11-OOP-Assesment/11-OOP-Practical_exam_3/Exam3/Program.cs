#define EXAM

using Exam3;
using System.Runtime.Intrinsics.X86;

namespace Exam3
{
  internal class Program
    {
        static void Main()
        {
            Console.WriteLine("###### Практически изпит XI клас в 4 варианта ######");
#if BACKERY
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
#endif
#if CAR
            Car c1 = new Car("Toyota", "Corolla сив бензин 110кс", 2020, 32000, 3, true);
                c1.PrintInfo();
                Car c2 = new Car("BMW", "X5 черен дизел 250кс", 2022, 95000, 2, true);
                c2.PrintInfo();

                Console.WriteLine("Въведете данни за нов автомобил:");
                Console.Write("Марка: ");
                string brand = Console.ReadLine();
                Console.Write("Описание (модел, цвят, гориво, мощност): ");
                string desc = Console.ReadLine();
                Console.Write("Година: ");
                int year = int.Parse(Console.ReadLine());
                Console.Write("Цена: ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Брой налични: ");
                int qty = int.Parse(Console.ReadLine());
                Console.Write("Произвежда се: ");
                bool available = Console.ReadLine().Trim().ToLower() == "да";

                Car c3 = new Car(brand, desc, year, price, qty, available);

                c3.PrintInfo(); 
#endif
#if BOUTIQUE
            ClothingItem item1 = new ClothingItem("Тениска CoolFit", "M", "Памук и еластан", 25.90, 10, true);
            item1.PrintInfo();
            ClothingItem item2 = new ClothingItem("Яке WinterPro", "L", "Полиестер и пух", 120.50, 3, false);
            item2.PrintInfo();

            Console.WriteLine("Въведете данни за трета дреха:");
            Console.Write("Етикет: ");
            string label = Console.ReadLine();
            Console.Write("Размер: ");
            string size = Console.ReadLine();
            Console.Write("Материя (поне 2 думи): ");
            string material = Console.ReadLine();
            Console.Write("Цена: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Бройки: ");
            int quantity = int.Parse(Console.ReadLine());
            Console.Write("Разпродажба (да/не): ");
            bool onSale = Console.ReadLine().Trim().ToLower() == "да";

            ClothingItem item3 = new ClothingItem(label, size, material, price, quantity, onSale);
            item3.PrintInfo();
#endif
#if SERVICE
            Device d1 = new Device("Лаптоп", "Не стартира, вероятно проблем с дъното", 10, 240.75, 2, true);
            d1.PrintInfo();
            Device d2 = new Device("Телефон", "Счупен дисплей и проблем със зарядното", 5, 120.50, 5, true);
            d2.PrintInfo();

            Console.WriteLine("Въведете данни за трето устройство:");
            Console.Write("Тип устройство: ");
            string type = Console.ReadLine();
            Console.Write("Описание на повредата (поне 4 думи): ");
            string desc = Console.ReadLine();
            Console.Write("Дни за ремонт (1–30): ");
            int days = int.Parse(Console.ReadLine());
            Console.Write("Цена на ремонта: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Брой подобни чакащи: ");
            int waiting = int.Parse(Console.ReadLine());
            Console.Write("Прието ли е за ремонт (да/не): ");
            bool accepted = Console.ReadLine().ToLower() == "да";

            Device d3 = new Device(type, desc, days, price, waiting, accepted);         
            
            d3.PrintInfo();
#else
            // Ако искате да стартирате дадена задача, в #define изпишете коя: BACKERY, CAR, BOUTIQYE, SERVICE
            
            try
            {
                // Тук тествам кода на ученици
                #region
                ServiceRepair device1 = new ServiceRepair("Laptop", "Does not start after software update", 5, 120.50m, 3, true);

                ServiceRepair device2 = new ServiceRepair("Phone", "Broken screen and touch not working", 2, 80.00m, 5, true);

                Console.WriteLine("Enter data for new device:\n");

                Console.Write("Device type: ");
                string type = Console.ReadLine();

                Console.Write("Damage description: ");
                string description = Console.ReadLine();

                Console.Write("Time for repair: ");
                int time = int.Parse(Console.ReadLine());

                Console.Write("Price for repair: ");
                decimal price = decimal.Parse(Console.ReadLine());

                Console.Write("Similar devices count: ");
                int count = int.Parse(Console.ReadLine());

                Console.Write("Acepted (true/false): ");
                bool accepted = bool.Parse(Console.ReadLine());

                ServiceRepair device3 = new ServiceRepair(type, description, time, price, count, accepted);


                device1.PrintLabel();
                device2.PrintLabel();
                device3.PrintLabel();
                #endregion
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.ReadKey();
        
#endif
        Console.WriteLine("###### XI class ######");

        }
    }
    // класът на ученика:
    internal class ServiceRepair 
    {
        private readonly string serviceName = "FixItService";

        public string deviceType;
        public string damageDescription;
        public int repairTime;
        public decimal repairPrice;
        public int similarDevicesCount;
        public bool accepted;

        public string DeviceType
        {
            get => deviceType;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Error");
                deviceType = value.Trim();
            }
        }

        public string DamageDescription
        {
            get => damageDescription;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Error");
                damageDescription = value.Trim();
            }
        }

        public int RepairTime
        {
            get => repairTime;
            set
            {
                if (value < 1)
                    throw new ArgumentException("Error");
                repairTime = value;
            }
        }

        public decimal RepairPrice
        {
            get => repairPrice;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Error");
                repairPrice = value;
            }
        }

        public int SimilarDevicesCount
        {
            get => similarDevicesCount;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Error");
                similarDevicesCount = value;
            }
        }

        public bool Accepted
        {
            get => accepted;
            set => accepted = value;
        }

        public ServiceRepair(string deviceType, string damageDescription, int repairTime, decimal repairPrice, int similarDevicesCount, bool accepted)
        {
            DeviceType = deviceType;
            DamageDescription = damageDescription;
            RepairTime = repairTime;
            RepairPrice = repairPrice;
            SimilarDevicesCount = similarDevicesCount;
            Accepted = accepted;
        }

        public decimal TotalPrice()
        {
            return Math.Round(RepairPrice * SimilarDevicesCount, 2);
        }

        public void PrintLabel()
        {
            Console.WriteLine("========================================");
            Console.WriteLine($"Service: {serviceName}");
            Console.WriteLine($"Device type: {DeviceType}");
            Console.WriteLine($"Damage description: {DamageDescription}");
            Console.WriteLine($"Time for the repair: {RepairTime} days");
            Console.WriteLine($"Price for repair: {RepairPrice:F2} BGN.");
            Console.WriteLine($"Similar devices count: {SimilarDevicesCount}");
            Console.WriteLine($"Accepted: {(Accepted ? "Yes" : "No")}");
            Console.WriteLine($"Total price: {TotalPrice():F2} BGN.");
            Console.WriteLine("========================================\n");
        }
    }
}

