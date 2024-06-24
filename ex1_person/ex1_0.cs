using System;

namespace _2024_JUNE_23_person
{

    class Person
    {
        public string name;
        public int age;

        public void Display()
        {
            Console.WriteLine($"Name : {this.name} \n Age : {this.age}");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person personObj = new Person();
            personObj.name = "Jerome";
            personObj.age=28;

            personObj.Display();

            Console.ReadLine();
        }
    }
}
