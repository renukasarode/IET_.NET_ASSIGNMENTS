using System.ComponentModel;

namespace _18_Demo_Delegates
{
    public delegate void myDelegate();
    public delegate void myDelegate2(string name);
    public delegate void myDelegate3(int x, int y);
    public delegate int myDelegate4(int x, int y, int z);
    internal class Program
    {
        static void Main(string[] args)
        {
            #region old way to use delegates

            Console.WriteLine("Hello, World!");
            myDelegate dell1 = new myDelegate(Program.SayHii);
            dell1.Invoke();

            Math m = new Math();
            Math m1 = new Math();
            //p.say
            myDelegate del2 = new myDelegate(m.sayHello);
            del2.Invoke();

            myDelegate2 del3 = new myDelegate2(m1.greet);
            del3.Invoke("renuka");

            Calculate cal = new Calculate();
            myDelegate3 del4 = new myDelegate3(cal.add);
            del4(3, 4);

            Calculate cal1 = new Calculate();
            myDelegate4 del5 = new myDelegate4(cal.add);
           int sum =  del5(1, 2, 3);
            Console.WriteLine($"addition is {sum}");




        } 
        #endregion

        public static void SayHii()
        {
            Console.WriteLine("hello welcome in delegate");

        }

        internal class Math
        {

            public void sayHello()
            {
                Console.WriteLine("hello from non static context");
            }

            public void greet(string name)
            {
                Console.WriteLine($"the name is {name}");

            }
        }

        internal class Calculate
        { 
            public void add(int x,int y)
            {
                Console.WriteLine($"the addition is {x+y}");
            }

            public int add(int x,int y,int z)
            {
                return x+y+z;
            }
        }
    }
}
