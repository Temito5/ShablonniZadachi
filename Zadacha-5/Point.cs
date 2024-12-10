using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_5
{
    public class Point<T> 
    {
        public T X { get; set; }
        public T Y { get; set; }

        public Point(T x, T y)
        {
            this.X = x;
            this.Y = y;
        }

        public double DistanceTo(Point<T> others)
        {
            double x1 = Convert.ToDouble(this.X);
            double y1 = Convert.ToDouble(this.Y);
            double x2 = Convert.ToDouble(others.X);
            double y2 = Convert.ToDouble(others.Y);

            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
