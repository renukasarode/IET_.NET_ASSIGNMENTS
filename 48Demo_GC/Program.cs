namespace _48Demo_GC
{
    
        internal class Program
        {
            static void Main(string[] args)
            {
                Myclass obj = new Myclass();
                obj.Dispose();
                obj.SayHi();

            using (Myclass obj2 = new Myclass())
            {
                obj2.SayHi();
            }
            //GC.Collect(2);
            //Console.WriteLine(g)

            }
        }
        public class Myclass : IDisposable
        {
            public void Dispose()
            {
                Console.WriteLine("dispose get called");
                //GC.SuppressFinalize(this);
            }
            public void SayHi()
            {
                Console.WriteLine("hii");
            }

        }
    

}
