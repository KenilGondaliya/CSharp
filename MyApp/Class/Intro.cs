using System;

namespace MyApp.Class
{
    public class Intro
    {
        public static void Run(string[] args)
        {
            // store 5 roll nos
            int[] numbers = new int[5];

            // store 5 names
            string[] names = new string[5];

            // data of 5 student: {roll no, names, marks}

            //int[] rollno = new int[5];
            //string[] name = new string[5];
            //float[] marks = new float[5]; 

            Student[] students = new Student[5];

            // declaring
            Student kenil = new Student(2, "jay", 55.5f);


            //kenil.rollno = 1;
            //kenil.name = "Kenil Gondaliya";
            //kenil.marks = 88.5f;

            Console.WriteLine(kenil.rollno);
            Console.WriteLine(kenil.name);
            Console.WriteLine(kenil.marks);

            
            Student random = new Student(kenil);

            Console.WriteLine(random.rollno);
        }
        
    }

}

