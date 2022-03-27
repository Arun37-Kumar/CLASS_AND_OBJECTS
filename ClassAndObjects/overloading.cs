using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects
{
    class overloading
    {
        public static float area(int x, int y)
        {
            return x * y;
        }
        public static int area(int x)
        {
            return x * x;
        }
    }
}
