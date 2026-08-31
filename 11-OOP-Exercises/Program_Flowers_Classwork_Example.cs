namespace classwork_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Flower f1 = new Flower("Розоцветни"); // РОДИТЕЛ
            f1.Blooming();
            f1.Oubaitori(); //общ за всички

            Rose r1 = new Rose("Императрица Фара", "малко");
            r1.Blooming();       // презаписан върху родителския
            r1.ThornsQuantity(); // специфичен за наследника
            r1.Oubaitori();

            Rose r2 = new Rose("Zephirine Drouhin", "напълно гладко стебло без");
            r2.Blooming();
            r2.ThornsQuantity();
            r2.Oubaitori();

            Rose r3 = new Rose("Rosa rugosa", "изключително много");
            r3.Blooming();
            r3.ThornsQuantity();
            r3.Oubaitori();
        }
    }
    class Flower
    {
        public string Name { get; set; }
        protected string fragrance { get; set; } = "благоуханен";

        public Flower(string name) 
        {
            Name = name;
        }

        public void Oubaitori() // общ за родителя и наследниците
        {
    Console.WriteLine(@"Oubaitori е японски идиом, според който цветята, както и хората, имат свое собствено темпо на цъфтеж и развитие.");
            Console.WriteLine(new string('~', 77));
        }
        public virtual void Blooming() // ще бъде променян = презаписван от наследниците
        {
            Console.WriteLine($"Цъфтящите \"{Name}\" са изключително красиви и имат {fragrance} аромат.");
        }
    }
    class Rose : Flower
    {
        public string Thorns { get; set; }
        public Rose(string name, string thorns) : base ( name ) 
        {
            Thorns = thorns; // имената вече са свързани в конструктора на родителя
        }
        public void ThornsQuantity() // специфичен за наследника метод
        {
            Console.WriteLine($"Сорт \"{Name}\" е с {Thorns} бодли.");
        }

        public override void Blooming() // променен върху родителския
        {
            fragrance = "деликатен";
            Console.WriteLine($"Розите цъфтят през цялото лято с {fragrance} аромат.");
        }
    }
}
