using System;

namespace MyApp.DataType
{
    class DelegateMain
    {
        public delegate void MyDelegate(string message);

        public static void DisplayMessage(string message)
        {
            Console.WriteLine($"Message: {message}");
        }

        public delegate void Notify(string message);

        public void MethodA(string message)
        {
            Console.WriteLine($"Method A: {message}");
        }

        public static void MethodB(string message)
        {
            Console.WriteLine($"Method B: {message}");
        }

        public static void Run(string[] args)
        {
            MyDelegate del = DisplayMessage;
            del("Hello from delegate!");

            var obj = new DelegateMain();
            Notify notify = obj.MethodA;

            notify("Hello from Notify!");
        }
    }
}