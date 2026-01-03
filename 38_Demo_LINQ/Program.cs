using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace _38_Demo_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, From Predicate-Deligate");

            #region Predicate-Deligate
            //Predicate<int> _isEven = num => num%2==0;
            //Predicate<int> _isOdd = num => num%2!=0;

            //Console.WriteLine("Enter the number");
            //int num = Convert.ToInt32(Console.ReadLine());
            //bool even = _isEven(num);
            //bool odd = _isOdd(num);
            //Console.WriteLine($"the even : {even} and odd : {odd}");

            #endregion

            #region Action Delegate
            //Action act1 = new Action(delegate ()
            //{
            //    Console.WriteLine("Hello from action delegate");
            //});
            //act1();

            //Action act2 = delegate ()
            //{
            //    Console.WriteLine("Hello from act2");
            //};
            //act2();

            //Action act3 = () =>
            //{
            //    Console.WriteLine("Hello from act3");
            //};
            //act3();

            //Action act4 = () => Console.WriteLine("Hello from act4");
            //act4();
            #endregion

            #region Func<out Result>

            // Func<int> func1 = new Func<int>(delegate ()
            // {
            //     return 1;
            // });
            // int result = func1();
            // Console.WriteLine(result);

            // Func<int> fun2 = delegate ()
            // {
            //     return 2;
            // };
            //int r1 =  fun2();
            // Console.WriteLine(r1);

            // Func<int> fun3 = ()=>{ return 3; };
            // int r3 = fun3();
            // Console.WriteLine(r3);

            // Func<int> fun4 = () => 4;
            // int r4= fun4();
            // Console.WriteLine(r4);

            // Func<string> func5 = () => "hello from IET";
            // string res5 = func5();
            // Console.WriteLine(res5);
            #endregion

            #region TResult Func<in T,out TResult>(T args)

            // Func<int, bool> fun1 = new Func<int, bool>(Check);
            //bool r1 =  fun1(5);
            // Console.WriteLine(r1);

            // Func<int, bool> fun2 = new Func<int,bool>(delegate (int num)
            // {
            //     return num%2==0;
            // });
            // bool r2 = fun2(5);
            // Console.WriteLine(r2);

            // Func<int, bool> fun3 = delegate (int num)
            // {
            //     return num%2==0;
            // };
            // bool r3 = fun3(4);
            // Console.WriteLine(r3);

            // Func<int, bool> fun4 = num => num%2==0;
            // bool r4 = fun4(10);
            // Console.WriteLine(r4);

            // Predicate<int> _predicate1 = (num) => num%2==0;
            // Predicate<int> _predicate2 = (num) => num%2!=0;
            // Predicate<int> _predicate3 = (num) => num>12;


            // Func<int, bool> func7 = new Func<int,bool>(_predicate1);
            // bool flag = func7(12);
            // Console.WriteLine($"from predicate1 {flag}");

            // Func<int, bool> fun8 = new Func<int, bool>(_predicate2);
            // Console.WriteLine($"from predicate1 {fun8(12)}");

            // Func<int, bool> fun9 = new Func<int, bool>(_predicate3);
            // Console.WriteLine($"from predicate1 {fun9(12)}");

            #endregion

            #region In built Where Extension method

            //  int[] arr = { 12, 1, 2, 11, 24, 3,45,54,45 };

            //  Console.WriteLine($"the sum of elements is {arr.Sum()}");
            //  Console.WriteLine($"the max is {arr.Max()}");

            //  Predicate<int> _predicate1 = num => num%2==0;
            //  Func<int,bool> func1 = new Func<int, bool>(_predicate1);
            //IEnumerable<int> ResultArr = arr.Where(func1);
            //  foreach(int element in ResultArr )
            //  {
            //    Console.WriteLine(element);
            //  }

            //  Predicate<int> _prediacate2 = num => num==45;
            //  Func<int,bool> fun3 = new Func<int,bool> (_prediacate2);
            //  IEnumerable<int> ResultArrr = arr.Where(fun3);
            //  foreach (int element in ResultArrr)
            //  {
            //      Console.WriteLine(element);
            //  }

            #endregion

            #region using the select built in extension method
            //int[] arr  = { 1, 2, 54, 45, 5, 6, 7 };

            //Func<int, int> fun4 = num => num*2;
            //IEnumerable<int> arrr2 = arr.Select(fun4);
            //var result = arr.Select(num=>num*7);
            //foreach (int element in result)
            //{
            //    Console.WriteLine(element);
            //}
            #endregion

            #region custom MySelect and MyWhere
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            Predicate<int> _predicate = num => num%2==0;
            Func<int, bool> fun1 = new Func<int, bool>(_predicate);
            
            //using MyWhere
           IEnumerable<int> list =  arr.MyWhere<int>(fun1);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            //using MySelect
            List<int> list1 = arr.MySelect().MyWhere(num=>num%2!=0);
            foreach (int i in list1)
            {
                Console.WriteLine(i);
            }

            #endregion
        }

        private static bool Check(int arg)
        {
            return arg%2==0;
        }
    }

    public static class MyClass
    {
        

        public static List<int> MySelect(this IEnumerable<int> list)
        {
            List<int> list1 = new List<int>();
            foreach (int i in list)
            {
                list1.Add(i);
            }
            return list1;

        }
        public static List<T> MyWhere<T>(this IEnumerable<T> predicate,Func<T, bool> predicate1)
        {
            List<T> list = new List<T>();
            foreach (T t in predicate)
            {
                if(predicate1(t))
                {
                    list.Add(t);
                }

            }
            return list;
        }
    }
}
