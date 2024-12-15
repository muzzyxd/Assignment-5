using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape");
        }
    }
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle");
        }
    }
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle");
        }
    }
    class Triangle : Shape
    {
        public override void Draw()
        {

            Console.WriteLine("Drawing a Triangle");
        }

        internal class Program
        {
        }
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[]
        {
            new Circle(),
            new Rectangle(),
            new Triangle()
        };

            foreach (Shape shape in shapes)
            {
                shape.Draw();
            }

            Console.ReadLine();
        }
}
}
