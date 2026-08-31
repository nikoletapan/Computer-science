namespace Rivers_lists
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            try
            {
                #region
                River river1 = new River(
                    "Марица",  
                    480, 
                    false,
                    "Реката преминава през южната част на страната."
                    );
                river1.DisplayInfo();
                Console.WriteLine(new string('°', 77));
                Console.WriteLine("Тест за защита: " + river1.Country);
                //river1.Country = "Гърция"; // Защита
                Console.WriteLine("Въведете данни за река на отделни редове: име, дължина, плавателна (да/не), описание:");
                River river2 = new River(
                    Console.ReadLine(),                      
                    int.Parse(Console.ReadLine()), 
                    Console.ReadLine().Trim().ToLower() == "да",
                    Console.ReadLine()
                    );
                river2.DisplayInfo();
                #endregion
            }
            catch (Exception ex)
            {
                Console.WriteLine("Грешка: " + ex.Message);
            }
            Console.ReadKey();
        }
    }

        class River
    {
        private readonly string country = "България"; // защитен и невидим в Main()
        private string name;
        private int length;
        private string description;

        public string Country { get; } // видим в Main()
        public string Name 
        { get => name; // или get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Въведете име!");
                name = value;
            }        
        }
        public int Length
        { get { return length; }
            set { if (value < 19)
                    throw new ArgumentException("Под 19 км е поток!");             
                length = value; }
        }
        public string Description
        {
            get => description;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Split().Length < 3) // 2 интервала
                    throw new ArgumentException("Описанието трябва да съдържа поне 3 думи!");
                description = value;
            }
        }
        public bool IsFloatable { get; set; }

        public River(string name, int length, bool isFloatable, string description)
        {
            Name = name;
            Length = length;
            IsFloatable = isFloatable;
            Description = description;
        }

        public void DisplayInfo()
        {
            //country = "Гърция";
            Console.WriteLine($"~°~°~°~ {country} ~°~°~°~");
            Console.WriteLine($"Река \"{Name}\" е {Length} км дълга.");
            Console.WriteLine("Плавателна: " + ((IsFloatable) ? "Да" : "Не"));
            Console.WriteLine("Описание: " + Description);
        }
    }
}
