using System;

namespace Program1
{
    class Rectangle : Figure
    {
        private Point a, c;
        private double square;

        public Rectangle(Point A, Point C)
        {
            a = A;
            c = C;
            square = Math.Abs((c.X - a.X) * (c.Y - a.Y));
        }

        public override Point A
        {
            get { return a; }
        }

        public Point C
        {
            get { return c; }
        }

        public override double Square
        {
            get { return square; }
        }
    }
}
