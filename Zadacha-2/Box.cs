using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_2
{
    public class Box<T>
    {
        private T item;

        public Box(T item)
        {
            this.item = item;   
        }

        public override string ToString()
        {
            return $"{GetType()/*.FullName*/}: {this.item}"; 
        }
    }
}
