using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingAndOverRiding
{
    internal class Operation2 : Imath
    {
        public void add(int x, int y)
        {
            Console.WriteLine("Addition from operation2 is "+(x + y));
        }

        public void add(int x, int y, int z)
        {
            Console.WriteLine("Addition from operation2 is "+(x + y+z));
        }

        public void add(int x, int y, int z, int m)
        {
            Console.WriteLine("Addition from operation2 is "+(x + y+z+m));
        }
    }
}
