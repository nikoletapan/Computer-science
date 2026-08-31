namespace Abstract_animal
{
    internal class Program
    {
        static void Main()
        {
            Animal a1 = new Dog();

            a1.Sleep(); // достъпно директно от родителя
            a1.Move();
            a1.Name = "Rex"; // без конструктор
            a1.Eat();
        }
    }
    abstract class Animal // РОДИТЕЛ
    {
        public string Name { get; set; }
        public void Sleep()
        {
            Console.WriteLine("The animal is sleeping.");
        }

        public virtual void Move()
        {
            Console.WriteLine("The animal is moving");
        }

        public abstract void Eat(); // понеже е абстрактен, има само име без тяло
    }
    class Dog : Animal // наследник1
    {
        public override void Move()
        {
            Console.WriteLine("The dog is moving.");
        }
        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }
    }
}
