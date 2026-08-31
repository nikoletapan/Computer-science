namespace AbstractGallery
    {
    class Program
    {
        static void Main()
        {
            PicassoGallery gallery = new PicassoGallery();

            Picasso guernica = new Guernica();
            Picasso oldGuitarist = new TheOldGuitarist();

            gallery.AddPainting(guernica);
            gallery.AddPainting(oldGuitarist);

            gallery.DisplayAllPaintings();

            gallery.DisplayStatistics();

            Console.WriteLine("ТЪРСЕНЕ НА КАРТИНИ ОТ 1937 ГОДИНА:");
            Console.WriteLine(new string('-', 40));

            var paintingsFrom1937 = gallery.FindPaintingsByYear(1937);
            foreach (var painting in paintingsFrom1937)
            {
                Console.WriteLine($"• {painting.Title} - {painting.GetDescription().Substring(0, 60)}...");
            }

            Console.WriteLine("\nПОЛИМОРФИЗЪМ - ИЗВИКВАНЕ ЧРЕЗ БАЗОВ КЛАС:");
            Console.WriteLine(new string('-', 40));

            Picasso[] picassoPaintings = { guernica, oldGuitarist };

            foreach (var painting in picassoPaintings)
            {
                Console.WriteLine($"{painting.Title}: {painting.GetEra()}");
            }

            Console.WriteLine("\nДОПЪЛНИТЕЛНА ИНФОРМАЦИЯ:");
            Console.WriteLine(new string('-', 40));

            Console.WriteLine($"\nДетайли за '{guernica.Title}':");
            Console.WriteLine($"Година: {guernica.Year}");
            Console.WriteLine($"Период: {guernica.GetEra()}");
            Console.WriteLine($"Местоположение: {guernica.Location}");
        }
    }
    abstract class Picasso
        {
             public abstract string Title { get; }
            public abstract int Year { get; }
            public abstract double Width { get; }
            public abstract double Height { get; }
            public abstract string Medium { get; }
            public abstract string Location { get; }
            public abstract decimal EstimatedValue { get; }

            public abstract string GetDescription();
            public void DisplayInfo()
            {
                Console.WriteLine(new string('=', 50));
                Console.WriteLine($"Картина: {Title}");
                Console.WriteLine(new string('-', 50));
                Console.WriteLine($"Година: {Year}");
                Console.WriteLine($"Размери: {Width} см x {Height} см");
                Console.WriteLine($"Техника: {Medium}");
                Console.WriteLine($"Местоположение: {Location}");
                Console.WriteLine($"Приблизителна стойност: {EstimatedValue:C}");
                Console.WriteLine($"Описание: {GetDescription()}");
                Console.WriteLine($"Площ на картината: {CalculateArea():F2} см²");
                Console.WriteLine(new string('=', 50));
                Console.WriteLine();
            }
            public double CalculateArea()
            {
                return Width * Height;
            }

            public virtual string GetEra()
            {
                return "XX век";
            }
        }
        class Guernica : Picasso
        {
            public override string Title => "Герника";
            public override int Year => 1937;
            public override double Width => 776;
            public override double Height => 349;
            public override string Medium => "Маслени бои върху платно";
            public override string Location => "Музей Рейна София, Мадрид, Испания";
            public override decimal EstimatedValue => 200_000_000m; // $200 милиона

            public override string GetDescription()
            {
                return "Монументална картина, изобразяваща трагедията от бомбардировката на Герника " +
                       "по време на Испанската гражданска война. Представлява силно антивоенно изявление " +
                       "в кубистичен стил с монохроматична палитра.";
            }

            public override string GetEra()
            {
                return "Кубистичен период, 1930-те години";
            }
        }

        class TheOldGuitarist : Picasso
        {
            public override string Title => "Старият китарист";
            public override int Year => 1903;
            public override double Width => 122.9;
            public override double Height => 82.6;
            public override string Medium => "Маслени бои върху платно";
            public override string Location => "Институт по изкуствата, Чикаго, САЩ";
            public override decimal EstimatedValue => 150_000_000m; // $150 милиона

            public override string GetDescription()
            {
            return "Картина от \"Синия период\" на Пикасо, изобразяваща сляп и беден " +
                       "старец, свирещ на китара. Монохроматичната синя палитра символизира " +
                       "меланхолия, бедност и отчаяние.";
            }

            public override string GetEra()
            {
                return "Син период (1901-1904)";
            }
        }

        class PicassoGallery
        {
            private List<Picasso> paintings;

            public PicassoGallery()
            {
                paintings = new List<Picasso>();
            }

            public void AddPainting(Picasso painting)
            {
                paintings.Add(painting);
            }

            public void DisplayAllPaintings()
            {
                Console.WriteLine("╔═════════════════════════════════════╗");
                Console.WriteLine("║            ПАБЛО ПИКАССО            ║");
                Console.WriteLine("╚═════════════════════════════════════╝");
                Console.WriteLine();

                foreach (var painting in paintings)
                {
                    painting.DisplayInfo();
                }
            }

            public void DisplayStatistics()
            {
                Console.WriteLine("СТАТИСТИКА НА КОЛЕКЦИЯТА:");
                Console.WriteLine(new string('-', 40));

                decimal totalValue = 0;
                double totalArea = 0;

                foreach (var painting in paintings)
                {
                    totalValue += painting.EstimatedValue;
                    totalArea += painting.CalculateArea();
                }

                Console.WriteLine($"Брой картини: {paintings.Count}");
                Console.WriteLine($"Обща стойност на колекцията: {totalValue:C}");
                Console.WriteLine($"Обща площ на всички картини: {totalArea:F2} см²");
                Console.WriteLine($"Средна стойност на картина: {totalValue / paintings.Count:C}");
                Console.WriteLine();

                Picasso mostExpensive = null;
                foreach (var painting in paintings)
                {
                    if (mostExpensive == null || painting.EstimatedValue > mostExpensive.EstimatedValue)
                    {
                        mostExpensive = painting;
                    }
                }

                if (mostExpensive != null)
                {
                    Console.WriteLine($"Най-скъпа картина: {mostExpensive.Title}");
                    Console.WriteLine($"Стойност: {mostExpensive.EstimatedValue:C}");
                }
            }

            public List<Picasso> FindPaintingsByYear(int year)
            {
                List<Picasso> result = new List<Picasso>();
                foreach (var painting in paintings)
                {
                    if (painting.Year == year)
                    {
                        result.Add(painting);
                    }
                }
                return result;
            }
        }

        
    }

