using System;

namespace _2024_JUNE_23_person
{

    class Person
    {
        public string name;
        protected int age;

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

    class Student : Person
    {
        public string studentId;

        public string Display()
        {
            return $"Name : {this.name} \n Age : {this.age} \n StudentId : {this.studentId}";
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

            Console.WriteLine("-------------------------------------------------------------------");

            Person stuObj1 = new Person();
            stuObj1.name = "Ram";
            stuObj1.SetAge(23);
            Console.WriteLine(stuObj1.Display());

            Console.WriteLine("-------------------------------------------------------------------");

            Person stuObj2 = new Student();
            stuObj2.name = "priya";
            stuObj2.SetAge(20);
            //stuObj2.studentId = "ST0001";
            Console.WriteLine(stuObj2.Display());

            Console.WriteLine("-------------------------------------------------------------------");

            Student stuObj3 = new Student();
            stuObj3.name = "Kumar";
            stuObj3.SetAge(21);
            stuObj3.studentId = "ST0002";
            Console.WriteLine(stuObj3.Display());

            Console.ReadLine();
        }
    }
}
