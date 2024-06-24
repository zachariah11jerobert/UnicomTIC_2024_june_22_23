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
            Circle[] circlesArray = new Circle[5];

            Circle circleObj1 = new Circle(7);
            Circle circleObj2 = new Circle(17);
            Circle circleObj3 = new Circle(70);
            Circle circleObj4 = new Circle(24);
            Circle circleObj5 = new Circle(45);

            circlesArray[0] = circleObj1;
            circlesArray[1] = circleObj2;
            circlesArray[2] = circleObj3;
            circlesArray[3] = circleObj4;
            circlesArray[4] = circleObj5;

            for (int i = 0; i < circlesArray.Length; i = i + 1)
            {
                Console.WriteLine("Circle Area : " + i + " : " + circlesArray[i].calculateArea());
            }

            Console.WriteLine("---------------------------------------------------------------------------------");

            Rectangle rectObj1 = new Rectangle(10, 3);
            Rectangle rectObj2 = new Rectangle(5, 4);
            Rectangle rectObj3 = new Rectangle(7, 8);

            Rectangle[] reactArray = { rectObj1, rectObj2, rectObj3 };

            for (int i = 0; i < reactArray.Length; i = i + 1)
            {
                Console.WriteLine("Reactangle Area : " + reactArray[i].calculateArea());
            }



            Console.ReadLine();
        }
    }
}
