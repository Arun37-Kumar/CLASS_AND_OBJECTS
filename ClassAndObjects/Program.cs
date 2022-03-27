using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float AreaOfRectangle = overloading.area(5,5);
            float AreaOfSquare = overloading.area(5);
            Console.WriteLine(AreaOfSquare);
            Console.WriteLine(AreaOfRectangle);
            Console.ReadLine();
        }
    }
}
