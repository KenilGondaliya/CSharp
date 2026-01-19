using System;


namespace MyApp.Inheritance
{
    public class BoxWeight : Box
    {
        public double weight;

        public BoxWeight()
        {
            this.weight = -1;
        }

        public BoxWeight(double side, double weight) : base(side) // call parent class constructor
        {
            this.weight = weight;
        }

        public BoxWeight(double l, double h, double w, double weight) : base(l, h, w) // call parent class constructor
        {
            Console.WriteLine(base.w);
            // use to initialize value present in parent class (base keyword)
            this.weight = weight;
        }

    }
}