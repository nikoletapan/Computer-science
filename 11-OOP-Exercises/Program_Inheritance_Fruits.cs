namespace Fruits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fruit f1 = new Fruit("Цитрус"); // РОДИТЕЛ
            f1.Taste();       // общ
            f1.Form();

            Lemon l1 = new Lemon("Лимон", "жълт"); // НАСЛЕДНИК
            l1.Taste();       
            l1.Appearance();  // специфичен за наследника
            l1.Form();        // презаписан
        }
    }
    class Fruit
    {
        public string Name { get; set; }
        protected string form { get; set; } = "кълбовидна";

        public Fruit(string name)
        {
            Name = name;       
        }
        public void Taste()
        {
            Console.WriteLine(new string('~', 77));
            Console.WriteLine($"Всички сортове \"{Name}\" са сладки, защото съдържат фруктоза.");
        }

        public void Form()
        {
            Console.WriteLine($"Всички плодове имат {form} форма.");
        }
    }
    class Lemon : Fruit
    {
        public string Color { get; set; }
        public Lemon(string name, string color) : base(name) // наследява родителския конструктор
        {
            Color = color;
        }

        public void Appearance()
        {
            Console.WriteLine($"Лимонът е {Color} на цвят.");
        }

        public void Form()
        {
            form = "удължен сфероид";
            Console.WriteLine($"Лимонът има форма на {form}.");
        }
    }
}
