namespace ConsoleApp3
{
    public class President
    {
        private string name;  // private field
        private string country; // lower case
        private int population = 6000000;
        private int area = 111000;

        public double Frequency()
        {
            Console.WriteLine($"Population: {population, -15} Area: {area, -15} ");
            return (double)population / (double)area;
        }
    }
    public class Library
    {
        public string Name { get; set; } // automatic property, new syntaxis
        public string Adress { get; set; } // prop + Tab + Tab
        public string Phone { get; set; } // private + public, not int!!!

        public void Information()
        {
            Console.WriteLine($@"{Name}
{Adress}
{Phone}");
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                President president1 = new President();
                Console.WriteLine(president1.Frequency());
            }
        }
    }
}
