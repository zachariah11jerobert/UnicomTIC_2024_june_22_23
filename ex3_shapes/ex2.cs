using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_JUNE_23_shapes
{

    class Rectangle
    {
        private float width;
        private float length;

        public Rectangle(float width, float length)
        {
            this.width = width;
            this.length = length;
        }

        public float calculateArea()
        {
            return this.width * this.length;
        }
    }
    class Circle
    {

        private float radius;

        public Circle(float radius)
        {
            this.radius = radius;
        }

        public float calculateArea()
        {
            return 3.14f * this.radius * this.radius;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circleObj = new Circle(7);
            Console.WriteLine("Circle Area : " + circleObj.calculateArea());

            Rectangle rectObj = new Rectangle(10,3);
            Console.WriteLine("Reactangle Area : " + rectObj.calculateArea());

            Console.ReadLine();
        }
    }
}
