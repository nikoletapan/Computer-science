using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_hierarchy
{
    public class Animal
    {
        public virtual void MakeSound() { Console.WriteLine("Some animal sound..."); }
        public virtual void Move() { Console.WriteLine("The animal moves."); }
        public void Sleep() { Console.WriteLine("The animal sleeps."); }
        public virtual void Eat() { Console.WriteLine("The animal eats."); }
    }
    public class Dog : Animal
    {
        public override void MakeSound() { Console.WriteLine("Dog barks."); }
        public override void Move() { Console.WriteLine("Dog runs."); }
    }
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            base.Eat(); // достъпваме родителски метод
            Console.WriteLine("Cat meows.");
        }
    }
    public class Fish : Animal
    {
        public override void Move() { Console.WriteLine("Fish swims."); }
    }

}
