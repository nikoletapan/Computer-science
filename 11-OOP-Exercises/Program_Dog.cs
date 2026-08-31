namespace DogExercise
{
   class Dog
    {
        public string Name;
        public string Breed;
    }

    class Rectangle
    {
        public double Width;
        public double Height;

        public static double Area(double Width, double Height)
        {
            return Width * Height;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog();
            dog1.Name = "Sharo";
            dog1.Breed = "Labrador";

            Console.WriteLine($"Name: {dog1.Name, -20} Breed: {dog1.Breed}");

            Dog dog2 = new Dog();
            dog2.Name = Console.ReadLine();
            dog2.Breed = Console.ReadLine();

            Console.WriteLine($"Name: {dog2.Name,-20} Breed: {dog2.Breed}");
            Rectangle rectangle = new Rectangle();
            rectangle.Area(3,4);

            Console.WriteLine(rectangle.Area(2,3));
        }
    }
}
