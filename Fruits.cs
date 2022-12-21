using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class Fruits
    {
        public void Taste()
        {
            Console.WriteLine("It can be either sweet or sour");
        }
    }
    public class Apple : Fruits
    {
        public void Color()
        {
            Console.WriteLine("The color of the apple is red");
        }
    }
}
