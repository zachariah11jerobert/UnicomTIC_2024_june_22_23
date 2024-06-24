using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_JUNE_Drive
{
    interface IDrivable
    {
        void Drive();
    }

    class Bike : IDrivable
    {
        public void Drive()
        {
            Console.WriteLine("Im Driving by 2 wheels");
        }
    }

    class Car : IDrivable {
        public void Drive()
        {
            Console.WriteLine("Im Driving by 4 wheels");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Bike bikeObj = new Bike();
            bikeObj.Drive();

            Car carObj = new Car();
            carObj.Drive();

            IDrivable obj1=new Bike();
            obj1.Drive();

            IDrivable obj2 = new Car();
            obj2.Drive();


            Console.ReadLine();
        }
    }
}
