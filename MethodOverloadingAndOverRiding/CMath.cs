using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingAndOverRiding
{
    internal class CMath
    {
        public void add(int a,int b)
        {
            Console.WriteLine("in add of cmath "+(a+b));
        }

        //method overloading within the same class
        public void add(int a, int b, int c)
        { 
            Console.WriteLine("in add of cMath "+(a+b+c));
        }

        public virtual void mul(int x, int y)
        {
            Console.WriteLine("from the mul of Cmath"+(x * y));
        }

        public void sub(int x, int y)
        {
            Console.WriteLine("from the sub of the cMath"+(x - y));
        }

    }

    internal class AdvancedMath : CMath
    {
        public override void mul(int x, int y)
        {
            Console.WriteLine("from the mul of advancedMath "+(x*y*100));
        }

        //shadowing the base class method
        public new void sub(int x, int y)
        {
            Console.WriteLine("from the sub of advancedMath "+(x-y));
        }

        public void add(int a, int b)
        {
            Console.WriteLine(a+b);
        }

        //method overLoading from the base class
        public void add(int a, int b, int c, int d)
        {
            Console.WriteLine("in add of AdvacnedMath "+(a+b+c+d));
        }
    }
}
