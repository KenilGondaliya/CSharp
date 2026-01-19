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

        public BoxWeight(double l, double h, double w, double weight) : base(l, h, w) // call parent class constructor
        {
            // use to initialize value present in parent class (base keyword)
            this.weight = weight;
        }


    }
}