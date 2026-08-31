namespace Abstract_instruments
{
    using System;
    class Program
    {
        static void Main()
        {
            DecoratedTitle();

            Instrument[] instruments = {
            new Piano ("Пиано"),          // с конструктор
            new Piano ("Орган"),
            new Guitar { Name = "Китара" },    // без конструктор
            new Guitar { Name = "Бас китара"}
            }; 

            foreach (var i in instruments)  // вместо var може Instrument - сложен съставен тип
            {
                i.PlayNote("До");
                Console.WriteLine($"Тип: {i.GetTypeName()}");
                Console.WriteLine(new string('~', 39));
            }

            DecoratedTitle();

            List<Instrument> instrumentsList = new List<Instrument>();
            instrumentsList.Add(new Piano("Пиано")); // с конструктор
            instrumentsList.Add(new Guitar { Name = "Китара" }); // без конструктор
             
            foreach (var i in instrumentsList)
            {
                i.PlayNote("Ре");
                Console.WriteLine($"Тип: {i.GetTypeName()}");
                Console.WriteLine(new string('~', 39));
            }
        }

        private static void DecoratedTitle()
        {
            Console.WriteLine("╔~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~╗");
            Console.WriteLine("{        Музикални инструменти        }");
            Console.WriteLine("╚~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~╝");
        }
    }
    abstract class Instrument
    {
        public string Name { get; set; }
        public abstract void PlayNote(string note);
        public abstract string GetTypeName();

        protected Instrument()
        {
        }
        protected Instrument(string name)
        {
            Name = name;
        }
    }

    class Piano : Instrument
    {
        public Piano(string name) : base(name)  // само клас Piano наследява конструктор
        {
        }
        public override void PlayNote(string note)
        {
            Console.WriteLine($"{Name} свири нота {note}.");
        }

        public override string GetTypeName() => "Клавишен"; // съкратено вместо { return } 
    }

    class Guitar : Instrument
    {
        public override void PlayNote(string note)
        {
            Console.WriteLine($"{Name} свири нота {note}.");
        }

        public override string GetTypeName() => "Струнен";
    }
}
