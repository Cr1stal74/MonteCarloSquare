using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Point
    {
        private double x;
        private double y;

        public double X
        {
            get { return x; }
        }

        public double Y
        {
            get { return y; }
        }

        public Point() //конструктор по умолчанию
        {
            x = 0;
            y = 0;
        }

        public Point(double a, double b) //конструктор по значению
        {
            x = a;
            y = b;
        }

        public Point(ref Point a) //конструктор копирования
        {
            x = a.X;
            y = a.Y;
        }
    }
}
