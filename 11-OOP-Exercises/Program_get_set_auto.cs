namespace get_set_auto
{
    public class FootballClub
    {
        private string name;   // private field
        private string stadium; // lower case
        private int players;

        public string Name      // public property
        {   get { return name; } // upper case
            set { 
                  if (string.IsNullOrWhiteSpace(value)) // по-интересен нов начин
                    throw new ArgumentNullException("The name cannot be empty!!!");
                else name = value; } 
        }
        public string Stadium
        {  get { return stadium; } 
           set { stadium = value; } 
        }
        public int Players
        {
            get { return players; }
            set { 
                if (players <= 0) Console.WriteLine("Out of range exception");
                else players = value; }
        }
        public int actualPlayers()
        {
            return players + 2;
        }
    }
    public class Cat
    {
        public string Name { get; set; } // prop + Tab + Tab
        public string Breed { get; set; } // automatic properties
        public int Age { get; set; }
        public int HumanAge() 
        { 
            return Age * 4 + 25 ;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat();
            cat1.Name = "Ori";
            cat1.Breed = "British";
            cat1.Age = 1;

            Console.WriteLine($"My cat is called {cat1.Name}. She is aproximately {cat1.HumanAge()} human ages.");
       
            FootballClub footballClub1 = new FootballClub();
            Console.Write("Enter name: ");
            footballClub1.Name = Console.ReadLine();
            footballClub1.Stadium = "Wembley";
            Console.Write("Number of players: ");
            footballClub1.Players = int.Parse(Console.ReadLine());

            Console.WriteLine($"The name is {footballClub1.Name}");
        }
    }
}
