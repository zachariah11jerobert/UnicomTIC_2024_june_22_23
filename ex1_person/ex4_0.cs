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

    class Student : Person
    {
        private string studentId;

        public string Display()
        {
            string str = base.Display();
            return $"{str} \n StudentId : {this.studentId}";
        }


        public Student() { }
        public Student(string studentId)
        {
            this.studentId = studentId;
        }

        public Student(string name, int age)
        {
            base.name = name;
            base.SetAge(age);
        }

        public Student(string name, int age, string studentId)
        {
            base.name = name;
            base.SetAge(age);
            this.studentId = studentId;
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
            //stuObj3.studentId = "ST0002";
            Console.WriteLine(stuObj3.Display());

            Console.WriteLine("-------------------------------------------------------------------");

            Student stuObj4 = new Student("ST0003");
            stuObj4.name = "Raju";
            stuObj4.SetAge(67);
            Console.WriteLine(stuObj4.Display());

            Console.WriteLine("-------------------------------------------------------------------");

            Student stuObj5 = new Student("Suresh", -23, "ST0004");
            Console.WriteLine(stuObj5.Display());

            Console.ReadLine();
        }
    }
}
