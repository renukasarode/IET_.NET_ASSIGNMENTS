using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInheritanceDemo
{
    internal class Base
    {
        public Base()
        {
            Console.WriteLine("in BaseClass defaultConstructor");
        }

        public Base(int id)
        {
            Console.WriteLine("in BaseClass Constructor {0}", id);
        }

        public void method1()
        {
            Console.WriteLine("in method1 of Base class");
        }
    }

    internal class Derived : Base
    {
        public Derived()
        {
            Console.WriteLine("you are in Derived Class defaultConstructor");
        }
        public Derived(int id):base(id) 
        {
            Console.WriteLine("you are in Derived Class COnstructor {0}",id);
        }

        public void method2()
        {
            Console.WriteLine("in method2 of Derived class");
        }
    }
}
