using System;


namespace MyApp.Interface
{
    public interface IEngine
    {
        public static int PRICE = 78000;
        void Start();
        void Stop();

        void Accelerate();

    }
}