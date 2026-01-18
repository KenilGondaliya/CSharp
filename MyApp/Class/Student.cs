using System;

namespace MyApp.Class
{

    public class Student
    {
        public int rollno;
        public string name;
        public float marks;


        public void greeting()
        {
            Console.WriteLine("Hello! My Name is " + this.name);
        }

        public void changeName(string name)
        {
            this.name = name;
        }


        // parameterized constructor
        public Student(int rno, string name, float marks)
        {
            this.rollno = rno;
            this.name = name;
            this.marks = marks;
        }

        // default constructor
        public Student()
        {
            rollno = 1;
            name = "Keni Gondaliya";
            marks = 85.5f;
        }

        public Student(Student other)
        {
            this.rollno = other.rollno;
            this.name = other.name;
            this.marks = other.marks;
        }
    }
}