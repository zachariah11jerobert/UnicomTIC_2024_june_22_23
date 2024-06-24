using System;

namespace _2024_JUNE_23_person
{

    class Person
    {
        public string name;
        protected int age;

        public virtual string Display()
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

        public override string Display()
        {
            string str = base.Display();
            return $"{str} \n StudentId : {this.studentId}";
        }

        public Student() { }

        public Student(string studentId)
        {
            this.studentId = studentId;
        }

        public Student(string name, int age, string studentId)
        {
            this.name = name;
            this.SetAge(age);
            this.studentId = studentId;
        }

        public virtual string Study()
        {
            return "I'm Studing";
        }


    }

    class GraduateStudent : Student
    {
        public string course;

        public GraduateStudent(string name, int age, string studentId, string course) : base(name,age,studentId)
        {

            this.course = course;
        }
        public override string Study()
        {
            return "I'm Studing " + this.course;
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

            Console.WriteLine("-------------------------------------------------------------------");

            Student stuObj4 = new Student("ST0003");
            stuObj4.name = "Raju";
            stuObj4.SetAge(67);
            Console.WriteLine(stuObj4.Display());

            Console.WriteLine("-------------------------------------------------------------------");

            Student stuObj5 = new Student("Suresh", -23, "ST0004");
            Console.WriteLine(stuObj5.Display());

            Console.WriteLine("-------------------------------------------------------------------");

            Student stuObj6 = new GraduateStudent("Roja",-34,"ST0007","JAVA");
            Console.WriteLine(stuObj6.Display());
            Console.WriteLine(stuObj6.Study());


            Console.ReadLine();
        }
    }
}
