using System;
using System.Collections.Generic;

namespace Student
{
    abstract class Student
    {
        public string state;
        public string name;
        public Student(string name)
        {
            this.name = name;
            this.state = new string("");
        }
        public abstract void Study();
        public void Read()
        {
            this.state += "Read ";
        }
        public void Write()
        {
            this.state += "Write ";
        }
        public void Relax()
        {
            this.state += "Relax ";
        }
    }
    class BadStudent : Student
    {
        public BadStudent(string name) : base(name)
        {
            this.name = name;
            this.state += " BAD ";
        }
        public override void Study()
        {
            this.Relax();
            this.Relax();
            this.Relax();
            this.Relax();
            this.Read();
        }
    }
    class GoodStudent : Student
    {
        public GoodStudent(string name) : base(name)
        {
            this.name = name;
            this.state += " GOOD ";
        }
        public override void Study()
        {
            this.Read();
            this.Write();
            this.Read();
            this.Write();
            this.Relax();
        }
    }
    class Group
    {
        string name;
        List<Student> students;
        public Group(string name)
        {
            this.name = name;
            this.students = new List<Student>();
        }
        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }
        public void GetInfo()
        {
            Console.WriteLine(this.name);
            foreach (var student in students)
                Console.WriteLine(student.name);
            Console.WriteLine("");
        }
        public void GetFullInfo()
        {
            Console.WriteLine(this.name);
            foreach (var student in students)
            {
                Console.WriteLine(student.name);
                Console.WriteLine(student.state);
            }
            Console.WriteLine("");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var group = new Group("123");
            var petrov = new BadStudent("Petrov");
            var sidorov = new GoodStudent("Sidorov");
            petrov.Study();
            sidorov.Study();
            group.AddStudent(petrov);
            group.AddStudent(sidorov);
            group.GetInfo();
            group.GetFullInfo();
        }
    }
}
