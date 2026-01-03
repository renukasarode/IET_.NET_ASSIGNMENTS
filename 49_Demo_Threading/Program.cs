




namespace _49_Demo_Threading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Default thread are  nameless
            Console.WriteLine(Thread.CurrentThread.Name);
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            Thread.CurrentThread.Name="main_Thread";
            Console.WriteLine(Thread.CurrentThread.Name);

            #endregion

            #region Normal Method call
            //method1();
            //method2();
            //method3();
            #endregion


            #region using ThreadStart

            ThreadStart ts = new ThreadStart(() => Console.WriteLine("hello From main thread"));
            Thread thread = new Thread(ts);
            thread.Start();

            Thread t1 = new Thread(method1) { Name="t1 th" };
            Thread t2 = new Thread(method2) { Name="t2 th" };
            Thread t3 = new Thread(method3) { Name = "t3 th" };
            t1.Start();
            t2.Start();
            t3.Start();

            #endregion

            #region isAlive And join method of thread class
            Console.WriteLine("The Execution of the main thread has started");
            Thread t4 = new Thread(f5);
            t4.Start();
            Thread t5 = new Thread(f6);
            t5.Start();


            if (t4.Join(2000))
            {
                Console.WriteLine("F1 execution complete");
            }

            t5.Join();
            Console.WriteLine("F2 execution complete");

            if (t4.IsAlive)
            {
                Console.WriteLine("F1 execution is still going on");
            }
            else
            {
                Console.WriteLine("F1 execution is complete");
            }

            Console.WriteLine("Main method execution complete");
            #endregion
        }

        private static void f6(object? obj)
        {
            Console.WriteLine("F2 method execution started");
        }

        private static void f5()
        {
            Console.WriteLine("the function f5 Execution started");
            Thread.Sleep(5000);
            Console.WriteLine("the function f5 is Alive");
            Console.WriteLine("the execution of the function is completed");
        }

        private static void method3()
        {
            Console.WriteLine($"Method started by thread {Thread.CurrentThread.Name}");
            for (int i = 0; i<5; i++)
            {
                Console.WriteLine($"Method3-count:{i}");
            }
            Console.WriteLine($"Method started by thread {Thread.CurrentThread.Name}");
        }

        private static void method2()
        {
            Console.WriteLine($"Method started by thread {Thread.CurrentThread.Name}");
            for (int i = 0; i<5; i++)
            {
                Console.WriteLine($"Method2-count:{i}");
            }
            Console.WriteLine($"Method started by thread {Thread.CurrentThread.Name}");
        }

        private static void method1()
        {
            Console.WriteLine($"Method started by thread {Thread.CurrentThread.Name}");
            for (int i = 0;i<5;i++)
            {
                Console.WriteLine($"Method1-count:{i}");
            }
             Console.WriteLine($"Method started by thread {Thread.CurrentThread.Name}");

        }
    }
}
