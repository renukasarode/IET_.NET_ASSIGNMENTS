using System;

namespace _25_Demo_Generic_Delegate
{
    public delegate void MyDelegate();
    public delegate void MyDelegate<T>(T t);
    public delegate void MyDelegate2<T>(T t,T r);
    public delegate R Mydelegate1<T,R>(T t, T r);
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from GenericDelegate");
            MyDelegate del1 = Program.Hello;
            del1();


            MyDelegate<string> del2 = Program.HelloName;
            del2("renuka");

            MyDelegate2<string> del3 = Program.ReturnStrings;
            del3("renuka","sarode");

            Mydelegate1<int,bool> del4 = Program.IsSumEven;
           Console.WriteLine(del4(1, 2));


            Mydelegate1<int, bool> del5 = Program.IsSumOdd;
            Console.WriteLine(del5(1, 2));

            MyDelegate2<string> del6  = Program.Greet;

            MyClass c1 = new MyClass();
            c1.display<string,string,string>(del6, "rtrtr","Good Morning");


        }

        private static void Greet(string name, string msg)
        {
            Console.WriteLine($"Hey!!! {name} {msg}");
        } 

        public static void Hello()
        {
            Console.WriteLine("Hello");
        }

        public static void HelloName(string name)
        { 
            Console.WriteLine($"hello {name}");
        }

        public static void ReturnStrings(string name,string lName)
        {
            Console.WriteLine($"hello {name} {lName}");
        }

        public static bool IsSumEven(int n1, int n2)
        {
           //Console.WriteLine((n1+n2)%2==0);
           return (n1+n2)%2==0;
        }

        public static bool IsSumOdd(int n1, int n2)
        {
            return (n1+n2)%2!=0;
        }
    }

    internal class MyClass
    {
          public void display<T1,T2,T3>(MyDelegate2<T1> del, T2 name, T3 msg)
          {
            //Console.WriteLine($"Hey...{name} {msg}");
            dynamic _name = name;
            dynamic _msg = msg;
            del.Invoke(_name, _msg);
          }
    }
}
