using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_4
{
    public class Point<T>
    {
        private T x,y;
        
        public T X { get { return x; } set { x = value; } }
        public T Y { get { return y; } set { y = value; } }

        public Point(T x, T y)
        {
            this.X = x;
            this.Y = y;
           
        }

        public T Swap()
        {
            T i =this.X;
            this.X = this.Y;
            this.Y = i;
            return x;
        }

        public void Print()
        {
            Console.WriteLine($"{this.X} {this.Y}") ;
        }
    }
}
