using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Смяна на координатите на точка

            Point<int> point = new Point<int>(3, 4);
            point.Swap();
            point.Print();
            
        }
    }
}
