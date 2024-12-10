using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_6
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

        public Point()
        {

        }

        public void Midpoint(Point<T> p1,Point<T> p2)
        {
            double x1 = Convert.ToDouble(p1.X);
            double y1 = Convert.ToDouble(p1.Y);
            double x2 = Convert.ToDouble(p2.X);
            double y2 = Convert.ToDouble(p2.Y);

            double midpointX = (x1 + x2) / 2;
            double midpointY = (y1 + y2) / 2;

            Console.WriteLine($"{midpointX},{midpointY}");
        }

    }
}
