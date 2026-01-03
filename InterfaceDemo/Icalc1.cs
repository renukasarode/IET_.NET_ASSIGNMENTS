using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal interface Icalc1
    {
        public void add(int x,int y);
        public void mul(int x,int y);
    }

    internal interface Icalc2
    {
        public void add(int x,int y);
        public void div(int x,int y);
    }

    internal class operation : Icalc1, Icalc2
    {
        //public void add(int x, int y)
        //{
        //    throw new NotImplementedException();
        //}

        //public void div(int x, int y)
        //{
        //    throw new NotImplementedException();
        //}

        //public void mul(int x, int y)
        //{
        //    throw new NotImplementedException();
        //}
        void Icalc1.add(int x, int y)
        {
            Console.WriteLine("YoU are in the add of Icalc1 {0}",x+y);
        }

        void Icalc2.add(int x, int y)
        {
            Console.WriteLine("YoU are in the add of Icalc2 {0}",x+y);
        }

        void Icalc2.div(int x, int y)
        {
            Console.WriteLine("YoU are in the div of Icalc2 {0}",x/y);
        }

        void Icalc1.mul(int x, int y)
        {
            Console.WriteLine("YoU are in the mul of Icalc1 {0}",x*y);
        }
    }
}
