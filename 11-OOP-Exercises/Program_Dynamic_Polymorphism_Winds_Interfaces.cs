using System;
using System.Collections.Generic;

namespace WindDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Wind> winds = new List<Wind>
            {                
                new Zephir(),
                new Breeze(),                
                new Monsoon(),
                new Fion(),
                new Mistral(),
            };

            Console.WriteLine($"=== {Wind.Heading().ToUpper()} ===");
            Console.WriteLine(new string('=', Wind.Heading().Length + 8));

            foreach (var wind in winds)
            {
                Console.WriteLine($"\n=== {wind.Name.ToUpper()} ===");

                if (wind is IVector vector)
                {
                    vector.Direction();
                    vector.Speed();
                }

                if (wind is IDescription description)
                {
                    description.Type();
                    description.Summary();
                }
            }

            Wind.Conclusion();
        }
    }
    abstract class Wind
    {
        public static string Heading() => "5-те най-известни вятъра";
        public abstract string Name { get; } 
        public static void Conclusion() => Console.WriteLine(@"
============== ИЗВОД: ============== 
Изредени са 5 известни вятъра, подредени по скорост:
3 морски (зефир, бриз, мусон) и 2 планински. 
Най-лекият и приятен е морският зефир, който присъства в поезията, 
а най-силен е алпийският мистрал, който на нася материални щети.");
    }

    interface IVector
    {
        void Direction();
        void Speed();
    }

    interface IDescription
    {
        void Type();
        void Summary();
    }

    class Zephir : Wind, IVector, IDescription
    {
        public override string Name => "Зефир";
        public void Direction()
        {
            Console.WriteLine("Посока: Западен вятър.");
        }

        public void Speed()
        {
            Console.WriteLine("Скорост: 1-5 m/s (лек вятър).");
        }
        public void Type() =>  // еквивалентен запис на {}, за разлика между 2-та интерфейса
            Console.WriteLine("Тип: Локален, приятен лек ветрец");

        public void Summary() =>
            Console.WriteLine("Описание: Лек западен вятър, характерен за Средиземноморието.");
    }
    class Breeze : Wind, IVector, IDescription
    {
        public override string Name => "Бриз";

        public void Direction() 
        {
            Console.WriteLine("Посока: Денем от морето към сушата, нощем - обратно.");
        }

        public void Speed()
        {
            Console.WriteLine("Скорост: 2-7 m/s (слаб до умерен).");
        }
        public void Type() => // еквивалентен запис на {}, за разлика между 2-та интерфейса
           Console.WriteLine("Тип: Периодичен, денонощен цикъл море-суша");

        public void Summary() =>
            Console.WriteLine("Описание: Променя посоката си през денонощието.");

    }
    class Monsoon : Wind, IVector, IDescription
    {
        public override string Name => "Мусон";

        public void Direction()
        {
            Console.WriteLine("Посока: Летният - от океана към сушата, зимният - обратно.");
        }

        public void Speed()
        {
            Console.WriteLine("Скорост: 5-20 m/s, понякога до 30 m/s.");
        }

        public void Type() => // еквивалентен запис на {}, за разлика между 2-та интерфейса
    Console.WriteLine("Тип: Периодичен вятър, свързан със сезонни дъждове в Азия");

        public void Summary() =>
            Console.WriteLine("Описание: Променят посоката си сезонно, характерни за Южна и Югоизточна Азия.");
    }
    class Fion : Wind, IVector, IDescription
    {
        public override string Name => "Фьон";

        public void Direction()
        {
            Console.WriteLine("Посока: От планинските склонове надолу.");
        }

        public void Speed()
        {
            Console.WriteLine("Скорост: 10-25 m/s, понякога над 30 m/s.");
        }

        public void Type() => // еквивалентен запис на {}, за разлика между 2-та интерфейса
            Console.WriteLine("Тип: Локален, топъл сух вятър");

        public void Summary() =>
            Console.WriteLine("Описание: Топъл, сух вятър от планините към долините.");
    }
    class Mistral : Wind, IVector, IDescription
    {
        public override string Name => "Мистрал";

        public void Direction()
        {
            Console.WriteLine("Посока: От север и северозапад към Средиземно море.");
        }

        public void Speed()
        {
            Console.WriteLine("Скорост: 15-25 m/s, понякога над 30 m/s.");
        }

        public void Type() => // еквивалентен запис на {}, за разлика между 2-та интерфейса
            Console.WriteLine("Тип: Локален, студен планински вятър");

        public void Summary() =>
            Console.WriteLine("Описание: Силен, студен вятър от Алпите към Средиземноморието.");
    }
}