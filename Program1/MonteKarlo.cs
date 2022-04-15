using System;

namespace Program1
{
    class MonteKarlo
    {
        private Point a;
        private Point c;
        private Figure leftCircle, rightCircle;
        private Figure rect;
        private double radius;

        public MonteKarlo(Point A, Point C)
        {
            a = new Point(A.X, A.Y);
            c = new Point(C.X, C.Y);
            leftCircle = new Circle(new Point(a.X, (c.Y + a.Y) / 2), (c.Y - a.Y) / 2);
            rightCircle = new Circle(new Point(c.X, (c.Y + a.Y) / 2), (c.Y - a.Y) / 2);
            rect = new Rectangle(a, c);
            radius = Math.Abs((c.Y - a.Y) / 2);
        }

        public double SquareFigure //Реальная площадь фигуры
        {
            get { return rect.Square - leftCircle.Square / 2 - rightCircle.Square / 2; } 
        }

        private bool IsInFigure(Point rnd) //Проверка на попадание в фигуру
        {

            if (rnd.X > (a.X + radius) && rnd.X < (c.X - radius)) //проверка на попадание во внутренний прямоугольник
            {
                return true;
            }
            else
            {
                double dLeft = Math.Sqrt(
                    Math.Pow(rnd.X - a.X, 2) +
                    Math.Pow(rnd.Y - 0.5 * (c.Y + a.Y), 2));
                double dRight = Math.Sqrt(
                    Math.Pow(rnd.X - c.X, 2) +
                    Math.Pow(rnd.Y - 0.5 * (c.Y + a.Y), 2));
                if(dLeft > dRight) //если точка ближе к правому полукругу
                {
                    if (dRight > radius) return true; //если расстояние от точки до центра круга больше радиуса, то точка попадает в фигуру
                    else return false;
                }
                else
                {
                    if (dLeft > radius) return true; //если расстояние от точки до центра круга больше радиуса, то точка попадает в фигуру
                    else return false;
                }
            }
        }

        public int CountPointsInFigure(int N, out double SquareMonteKarlo, out double Error) //количество попавших в фигуру точек
        {
            double xRnd; //координата X рандомной точки
            double yRnd; //координата Y рандомной точки
            int inFigurePoints = 0;
            Random rand = new Random();
            for (int i = 0; i < N; i++)
            {
                xRnd = (c.X - a.X) * rand.NextDouble() + a.X;
                yRnd = (c.Y -  a.Y) * rand.NextDouble() + a.Y;
                Point rnd = new Point(xRnd, yRnd);
                if (IsInFigure(rnd))
                {
                    inFigurePoints++;
                }
            }
            SquareMonteKarlo = (double)inFigurePoints / (double)N * rect.Square;
            Error = Math.Abs(SquareMonteKarlo - SquareFigure) / SquareFigure * 100;
            return inFigurePoints;
        }
    }
}
