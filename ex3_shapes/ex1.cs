using System;


namespace _2024_JUNE_23_shapes
{

    class Rectangle
    {
        public float calculateArea(float width, float length)
        {
            return width * length;
        }
    }
    class Circle
    {
        public float calculateArea(float radius)
        {
            return 3.14f * radius * radius;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circleObj = new Circle();
            Console.WriteLine("Circle Area : " + circleObj.calculateArea(7));

            Rectangle rectObj = new Rectangle();
            Console.WriteLine("Reactangle Area : " + rectObj.calculateArea(10, 3));

            Console.ReadLine();
        }
    }
}
