using System;

namespace _2024_JUNE_23_person
{

    class Person
    {
        public string name;
        public int age;

        public string Display()
        {
            return $"Name : {this.name} \n Age : {this.age}";
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person personObj = new Person();
            personObj.name = "Jerome";
            personObj.age=28;

            Console.WriteLine(personObj.Display());

            Console.ReadLine();
        }
    }
}
