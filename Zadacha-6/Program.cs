using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Средна точка

            Point<double> p1 = new Point<double>(2.0, 4.0);
            Point<double> p2 = new Point<double>(6.0, 8.0);

            Point<double> p3=new Point<double>();
            p3.Midpoint(p1, p2);
        }
    }
}
