using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Кутия за всичко

            Box<int> num =new Box<int>(int.Parse(Console.ReadLine()));
            Console.WriteLine(num.ToString());

            Box<string> duma = new Box<string>(Console.ReadLine());
            Console.WriteLine(duma.ToString());
        }
    }
}
