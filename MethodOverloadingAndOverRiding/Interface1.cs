using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingAndOverRiding
{
    internal interface Imath
    {
        public void add(int  x, int y);
        public void add(int x, int y,int z);
        public void add(int x, int y,int z,int m);
    }
}
