namespace Static_polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            Console.WriteLine($@"--- Methods overloading results ---
First result: {c.Add(2, 3)}
Second result: {c.Add(4.5, 5.6)} 
Third result: {c.Add(7, 8, 9)}");

            Console.WriteLine($@"--- Static polymorphism ---");
            Calculator c1 = new Calculator("input value");
            c1.name = "changed value";
            Console.WriteLine(c1.ToString());

            Console.WriteLine($@"--- Testing polymorphism ---");
            Calculator c3 = new Calculator();
            c3.name = "first ctor with included name";
            Console.WriteLine($"One of methods: {c3.Add(12.34, 56.78)}");
            Console.WriteLine(c3.ToString());
        }
    }
    class Calculator
    {
        protected internal string name;
        public Calculator() // ctor + tab + tab
        {
        }
        public Calculator(string name) // конструира нов обект
        {
            this.name = name;
        }
        public override string ToString()
        {
            return $"This is {name}";
        }
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
