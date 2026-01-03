namespace _44Demo_StoredProcedure
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Myclass obj = new Myclass();
            obj.Dispose();
            obj.SayHi();

        }
    }
    public class Myclass : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("dispose get called");
            throw new NotImplementedException();
        }
        public void SayHi()
        {
            Console.WriteLine("hii");
        }

    }
}
