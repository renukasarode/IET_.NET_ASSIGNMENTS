namespace Tuple_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            // dynamic x =getData(10, 20, "renuka");
            (int,int,string) x = getData(10, 20, "renuka");
            Console.WriteLine(x);
        }

        static (int,int,string) getData(int x,int y,string name)
        {
            return (x,y,name);
        }
    }
}
