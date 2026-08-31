namespace Rivers_validations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

            }
            catch (Exception ex) { 
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.ReadKey();
        }
    }
    class River
    {
        //private readonly string country = "Bulgaria"; // unvisible in Main
        private string name;
        private int length;
        private string description;
        public string Country { get; } = "Bulgaria"; // visible in Main
                
        public string Name {
            get => name;
            set
            {   if(string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Empty name!");
                name = value;
            } 
        }
        public int Length {
            get => length; 
            set
            {
                if (value < 10)
                    throw new ArgumentException("Short length!");
                length = value;
            }
        }
        public string Description 
        { get => description; 
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Split().Length < 3) // 3 words
                    throw new ArgumentException("3 words minimum!");
                description = value;
            }
        }
        public bool IsFloatable { get; set; }

        public River(string name, int length, string description, bool isFloatable)
        {
            Name = name;
            Length = length;
            Description = description;
            IsFloatable = isFloatable;
        }

        public void DisplayInfo()
        {
            Console.WriteLine(Country);
            Console.WriteLine($"");
        }
    }
}
