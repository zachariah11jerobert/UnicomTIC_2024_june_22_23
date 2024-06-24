using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_JUNE_23_shapes
{

    class Shape
    {
        public virtual float calculateArea()
        {
            return 0;
        }
    }

    class Rectangle : Shape
    {
        private float width;
        private float length;

        public Rectangle(float width, float length)
        {
            this.width = width;
            this.length = length;
        }

        public override float calculateArea()
        {
            return this.width * this.length;
        }
    }
    class Circle : Shape
    {

        private float radius;

        public Circle(float radius)
        {
            this.radius = radius;
        }

        public override float calculateArea()
        {
            return 3.14f * this.radius * this.radius;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape circleObj1 = new Circle(7);
            Console.WriteLine("Circle Area : " + 1 + " : " + circleObj1.calculateArea());

            Console.ReadLine();
        }
    }
}
