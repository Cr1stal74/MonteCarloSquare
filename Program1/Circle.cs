using System;

namespace Program1
{
    class Circle : Figure
    {
        Point a;
        double r;
        double square;

        public Circle(Point a, double r)
        {
            this.a = a;
            this.r = r;
            square = Math.PI * Math.Pow(r, 2);
        }

        public override Point A
        {
            get { return a; }
        }

        public double R
        {
            get { return r; }
        }

        public override double Square
        {
            get { return square; }
        }
    }
}
