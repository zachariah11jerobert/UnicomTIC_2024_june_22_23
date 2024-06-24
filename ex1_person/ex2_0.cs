using System;

namespace _2024_JUNE_23_person
{

    class Person
    {
        public string name;
        private int age;

        public string Display()
        {
            return $"Name : {this.name} \n Age : {this.age}";
        }

        public void SetAge(int age)
        {
            if (age < 0)
            {
                this.age = -(age);
            }
            else
            {
                this.age = age;

            }
        }

        public int GetAge()
        {
            return this.age;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person personObj = new Person();
            personObj.name = "Jerome";
            personObj.SetAge(28);

            Console.WriteLine(personObj.Display());

            Console.ReadLine();
        }
    }
}
