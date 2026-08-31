namespace Shapes_override_new
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Circle(), new Square(), new Rectangle(), new Triangle() };
            foreach (var s in shapes) s.Draw();
        }
    }
    public class Shape
    {
        public virtual void Draw() { Console.WriteLine("Drawing a generic shape..."); }
    }

    public class Circle : Shape
    {
        public sealed override void Draw() { Console.WriteLine("Drawing a circle..."); }
    }

    public class Square : Circle
    {
        //public override void Draw() { Console.WriteLine("Drawing a square..."); } // забранено
        public new void Draw() { Console.WriteLine("Drawing a square..."); } // отпечатва родителя circle
    }

    public class Rectangle : Shape
    {
        public new void Draw() { Console.WriteLine("Drawing a rectangle..."); } // отпечатва родителя  
    }

    public class Triangle : Shape
    {
        public override void Draw() { base.Draw(); Console.WriteLine("Drawing a triangle..."); } // отпечатва родителя + triangle
    }
}
