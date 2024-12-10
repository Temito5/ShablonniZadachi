using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Zadacha_2;

namespace Zadacha_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Универсална кутия за низове

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Box<string> box = new Box<string>(Console.ReadLine());
                Console.WriteLine(box.ToString());
            }
        }
    }
}
