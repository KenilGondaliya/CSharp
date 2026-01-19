using System;

namespace MyApp.Inheritance
{
    public class Main
    {
        public static void Run()
        {
            // Box box1 = new Box(4.6, 7.9, 9.9);
            // // Box box2 = new Box(box1);
            // Console.WriteLine(box1.l + " " + box1.h + " " + box1.w);

            // Box box3 = new BoxWeight();
            // Box box4 = new BoxWeight(2,3,4,8);

            // Console.WriteLine(box3.l + " " + box3.h + " " + box3.w);

            // Box box5 = new BoxWeight(2, 3, 4, 10);
            // Console.WriteLine(box5.weight);

            // there are many variable in both parent and child class
            // you are given access the variable that are in the ref type i.e. BoxWight
            // hence, you should have access to weight variable
            // that also means , that the ones you are trying to access should be initialized
            // but here, when object itself is of type parent class, How you call the constructor of child class
            
            // BoxWeight box6 = new Box(2, 3, 4, 10);
            // Console.WriteLine(box6);
            


            // BoxPrice box = new BoxPrice(5,8,200);

            Box.greeting(); // you can inherit static method but not override
        }
    }
}