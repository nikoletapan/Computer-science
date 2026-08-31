using System;
using System.Collections.Generic;
using System.Linq;

namespace PicassoGallery
{
    class Program
    {
        static List<Gallery> allPaintings = new List<Gallery>();

        static void Main()
        {
            try
            {
                AddPaintings();
                allPaintings.Add(new CubistPainting(
                "Тримата музиканти", 1921, "203.2 x 187.9 cm",
                "Музей за модерно изкуство, Ню Йорк", 120000000m, "Кубизъм", "Синтетичен"));

                DisplayHeading();

                MostExpensive();

                AlphabeticalOrder(allPaintings);
                ShowDescriptions();

                Console.Write("Потърсете в архива: ");
                string searchTitle = Console.ReadLine();
                ShowDetails(searchTitle);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Грешка: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("<<<<<<< ARS LONGA, VITA BREVIS >>>>>>>");
            }
            Console.ReadKey();
        }

        static void AddPaintings()
        {
            allPaintings.Add(new EarlyPainting(
                "Старият китарист", 1903, "122.9 x 82.6 cm",
                "Чикагски институт по изкуствата", 60000000m, "Синя епоха"
            ));

            allPaintings.Add(new EarlyPainting(
                "Животът", 1903, "196.5 x 129.2 cm",
                "Музей на изкуството, Кливланд", 50000000m, "Синя епоха"
            ));

            allPaintings.Add(new EarlyPainting(
                "Младият акробат", 1905, "93.3 x 80.6 cm",
                "Музей за модерно изкуство, Ню Йорк", 45000000m, "Розова епоха"
            ));

            allPaintings.Add(new CubistPainting(
                "Герника", 1937, "349 x 776 cm",
                "Музей София, Мадрид", 200000000m, "Кубизъм", "Аналитичен"
            ));
            // Демонстрираме грешка в съответствие година - период
            /*
            allPaintings.Add(new CubistPainting(
                "Авиньонските момичета", 1907, "243.9 x 233.7 cm",
                "Музей за модерно изкуство, Ню Йорк", 150000000m, "Прото-кубизъм", "Аналитичен"
            ));*/

            allPaintings.Add(new CubistPainting(
                "Плачещата жена", 1937, "60 x 49 cm",
                "Тейт Модърн, Лондон", 80000000m, "Кубизъм", "Синтетичен"
            ));
        }

        static void DisplayHeading()
        {
            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║            ПАБЛО ПИКАСО            ║");
            Console.WriteLine("╚════════════════════════════════════╝");
            Console.WriteLine("=== Всички картини в галерията ===");

            Console.WriteLine($"Общ брой: {Gallery.counter}\n");
        }

        static void MostExpensive()
        {
            Console.WriteLine("=== НАЙ-СКЪПА КАРТИНА ===");

            var mostExpensive = allPaintings.MaxBy(p => GetPaintingValue(p));

            Console.WriteLine($"\"{mostExpensive.Title}\", цена: {GetPaintingValue(mostExpensive):C}");

            static decimal GetPaintingValue(Gallery painting)
            {
                if (painting is EarlyPainting early)
                    return early.EstimatedValue;
                else if (painting is CubistPainting cubist)
                    return cubist.EstimatedValue;
                return 0;
            }
            Console.WriteLine();
        }

        private static void AlphabeticalOrder(List<Gallery> allPaintings)
        {
            Console.WriteLine("=== КАРТИНИ ПО АЗБУЧЕН РЕД ===");
            var orderedPaintings = allPaintings.OrderBy(p => p.Title).ToList();
            foreach (var painting in orderedPaintings)
            {
                Console.WriteLine($" ■ {painting.Title}");
            }
            Console.WriteLine();
        }

        static void ShowDescriptions()
        {
            Console.WriteLine("=== КРАТКИ ОПИСАНИЯ ===");
            foreach (var painting in allPaintings)
            {
                painting.Description();
            }
            Console.WriteLine();
        }

        static void ShowDetails(string searchTitle)
        {
            Console.WriteLine("=== СПИСЪК СЪС СЪОТВЕТСТВАЩИ КАРТИНИ ===");
            var searchResults = allPaintings.Where(p => p.Title.Contains(searchTitle));
            foreach (var painting in searchResults)
            {
                painting.Details();
            }
        }
    }
    public abstract class Gallery
    {
        public string Title { get; protected set; } // всички четат, само protected пишат
        public string Artist { get; } = "Пабло Пикасо"; // read-only
        protected internal string Style { get; set; }

        protected internal static int counter = 0;

        protected Gallery(string title, string style)
        {
            counter++;
            Title = string.IsNullOrWhiteSpace(title) ? "Неизвестна картина" : title;
            Style = style;
        }

        public virtual void Description()
        {
            Console.WriteLine($"\"{Title}\" в стил {Style}");
        }

        public abstract void Details();

         public abstract string PeriodCharacteristics();
    }

    public class EarlyPainting : Gallery
    {
        public int YearCreated { get; private set; }
        public string Dimensions { get; private set; }
        public string Location { get; private set; }
        public decimal EstimatedValue { get; private set; }
        public string Period { get; private set; }

        public EarlyPainting(string title, int year, string dimensions,
                                   string location, decimal value, string style)
            : base(title, style)
        {
            if (year < 1900 || year > 1909)
                throw new ArgumentException("Ранният период е 1900-1909 г.");

            YearCreated = YearCreated < 0  ?  1900 : year;
            Dimensions = dimensions;
            Location = location;
            EstimatedValue = value;
            Period = "Ранен период (1900-1909)";
        }

        public override void Description()
        {
            Console.WriteLine($"◄\"{Title}\", ({YearCreated}) / {Period}. {GetShortDescription()}");
        }

        public override void Details()
        {
            Console.WriteLine("=== Подробни характеристики ===");
            Console.WriteLine($"Заглавие: \"{Title}\"");
            Console.WriteLine($"Художник: {Artist}");
            Console.WriteLine($"Период: {Period}");
            Console.WriteLine($"Година на създаване: {YearCreated}");
            Console.WriteLine($"Размери: {Dimensions}");
            Console.WriteLine($"Местоположение: {Location}");
            Console.WriteLine($"Оценявана стойност: {EstimatedValue:C}");
            Console.WriteLine($"Стил: {Style}");
            Console.WriteLine($"Характеристики на периода: {PeriodCharacteristics()}");
            Console.WriteLine();
        }

        public override string PeriodCharacteristics()
        {
            return "Синя и Розова епоха, меланхолия, социални теми, цигани, артисти";
        }

        private string GetShortDescription()
        {
            return "Меланхолични тонове, социална тематика, емоционална дълбочина.";
        }
    }

    public class CubistPainting : Gallery
    {
        public int YearCreated { get; private set; }
        public string Dimensions { get; private set; }
        public string Location { get; private set; }
        public decimal EstimatedValue { get; private set; }
        public string Period { get; private set; }
        public string CubistPhase { get; private set; } // Аналитичен/Синтетичен кубизъм

        public CubistPainting(string title, int year, string dimensions,
                                    string location, decimal value, string style, string cubistPhase)
            : base(title, style)
        {
            if (year < 1910 || year > 1973)
                throw new ArgumentException("Кубистичният период е 1910-1973 г.");

            YearCreated = year;
            Dimensions = dimensions;
            Location = location;
            EstimatedValue = value;
            Period = "Кубистичен и по-късен период (1910-1973)";
            CubistPhase = cubistPhase;
        }

        public override void Description()
        {
            Console.WriteLine($"►\"{Title}\", ({YearCreated}) / {CubistPhase} кубизъм. {GetShortDescription()}");
        }

        public override void Details()
        {
            Console.WriteLine("=== Подробни характеристики (Кубистичен период) ===");
            Console.WriteLine($"Заглавие: \"{Title}\"");
            Console.WriteLine($"Художник: {Artist}");
            Console.WriteLine($"Период: {Period}");
            Console.WriteLine($"Фаза на кубизъма: {CubistPhase}");
            Console.WriteLine($"Година на създаване: {YearCreated}");
            Console.WriteLine($"Размери: {Dimensions}");
            Console.WriteLine($"Местоположение: {Location}");
            Console.WriteLine($"Оценявана стойност: {EstimatedValue:C}");
            Console.WriteLine($"Стил: {Style}");
            Console.WriteLine($"Характеристики на периода: {PeriodCharacteristics()}");
            Console.WriteLine();
        }

        public override string PeriodCharacteristics()
        {
            return "Деформация на форми, множествена перспектива, геометрични форми, колаж";
        }

        private string GetShortDescription()
        {
            return "Иновативен подход, революция в изкуството, геометрични форми.";
        }
    }
}