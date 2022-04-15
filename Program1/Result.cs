using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Result
    {
        public int Id { get; set; } //номер измерения
        public int Points { get; set; } //количество точек
        public double MonteCarloSquare { get; set; } //Площадь по методу Монте-Карло
        public int CountPoints { get; set; } //Количество попавших точек
        public double Uncertainity { get; set; } //Погрешность
        public double Time { get; set; } //Время, затраченное на вычисление
    }
}
