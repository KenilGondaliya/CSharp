using System;


namespace MyApp.Inheritance
{
    public class BoxPrice : BoxWeight
    {
        double cost;

        public BoxPrice(BoxPrice other) : base(other.l, other.h, other.w, other.weight)
        {
            this.cost = other.cost;
        }

        public BoxPrice(double l, double h, double w, double weight, double cost) : base(l, h, w, weight)
        {
            this.cost = cost;
        }

        public BoxPrice(double side, double weight, double cost) : base(side, weight)
        {
            this.cost = cost;
        }
       
    }
}