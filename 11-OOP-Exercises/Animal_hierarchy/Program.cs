namespace Animal_hierarchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal> { new Dog(), new Cat(), new Fish() };

            foreach (var a in animals)
            {
                a.MakeSound(); // Dog, Cat, parent
                a.Move();      // Dog, parent, Fish
                a.Sleep();     // always = not virtual
                Console.WriteLine(new string('-', 33));
            }

        }
    }
}
