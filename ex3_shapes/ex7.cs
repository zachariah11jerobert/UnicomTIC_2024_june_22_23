using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_JUNE_23_shapes
{

    abstract class Shape
    {
        public abstract float calculateArea();

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

            Shape[] shapesArray = new Shape[5];

            Shape circleObj1 = new Circle(7);
            Shape circleObj2 = new Circle(14);
            Circle circleObj3 = new Circle(70);
            Rectangle rectObj1 = new Rectangle(10, 3);
            Rectangle rectObj2 = new Rectangle(5, 4); ;

            shapesArray[0] = circleObj1;
            shapesArray[1] = circleObj2;
            shapesArray[2] = circleObj3;
            shapesArray[3] = rectObj1;
            shapesArray[4] = rectObj2;



            for (int i = 0; i < shapesArray.Length; i = i + 1)
            {
                Console.WriteLine("Area : " + shapesArray[i].calculateArea());
            }


            Console.ReadLine();
        }
    }
}
