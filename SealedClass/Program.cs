namespace SealedClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            AdvancedMath c1 = new Math2();
            Console.WriteLine(c1.mul(1, 2));

            Math2 m1 = new Math2();
            m1.SayHello();
            Console.WriteLine(m1.mul(5, 2));
        }
    }
    public sealed class Cmath
    {
        public int add(int x, int y) 
        {
            return x+y;
        }

        public int add(int x, int y,int z)
        {
            return x+y+z;
        }
    }

    public class AdvancedMath //: Cmath
    {
        public virtual int mul(int x, int y)
        { 
          return x*y;
        }

    }

    public class Math1:AdvancedMath
    {
        public sealed override int mul(int x, int y)
        {
            return x*y*x;
        }

        public virtual void SayHello()
        {
            Console.WriteLine("say hello from math1");
        }
    }

    public class Math2 : Math1
    {
        //cannot overrite because it is sealed......
        //public sealed override int mul(int x, int y)
        //{
        //    return x*y*x;
        //}
        public sealed override void SayHello()
        {
            Console.WriteLine("say hello from math2");
        }
    }
}
