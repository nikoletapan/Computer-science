namespace Objects
{
    public class Triangle
    {
        private int ab; // private field
        private int bc;
        private int ca;

        public int AB   // public property
        {
            get { return ab; }  // validation
            set { ab = value; } // validation
        }
    public class Person
    {
        public string Name { get; set; } // automatic properties
        public int Age { get; set; }     // prop + Tab + Tab
        public double High { get; set; }    // private + public = new syntaxis

        public void PersonalData()   // method = action
        {
            Console.WriteLine($"Name: {Name, -15} Age: {Age, -15} High: {High}");
        }
    }
    public class Airport
    {
        private string country; // private field
        private string city;
        private int planeNumbers = 60;

        public int DailyFlys()
        {
            return planeNumbers / 2;
        }
    }
    public class School
    {
        public string Name; //  public properties
        public string Adress;
        public int StudentsNumber;

        public void Quantity()   // action
        {
            if (StudentsNumber <= 500)
                Console.WriteLine("Small school.");
            else Console.WriteLine("Huge school.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            School school1 = new School();
            school1.Name = "MG \"Acad. K. Popov\"";
            school1.Adress = "Chemshir str. No 1";
            school1.StudentsNumber = 400;

Console.WriteLine($@"{school1.Name} 
{school1.Adress}");
            school1.Quantity();
            School school2 = new School();

            Airport airport1 = new Airport();
            
            Console.WriteLine($"The number of daily flys are: {airport1.DailyFlys()}");


        }
    }
}
