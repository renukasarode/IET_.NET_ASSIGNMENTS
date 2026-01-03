namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("hello from first .Net");
            int star = 0;
            int n = 5;

            for (int i = 0; i<n; i++)
            {
                for (int j = 0; j<n/2-star; j++)
                {
                    Console.Write(" "+" ");
                }
                for (int j = 0; j<=2*star; j++)
                {
                    if (j==0 || j==2*star)
                    
                        Console.Write("*"+" ");
                    
                    else
                     
                    Console.Write(" "+" ");

                }
                if (i<n/2)
                {
                    star++;
                }
                else
                {
                    star--;
                }
                    Console.WriteLine();
            }
        }
    }
}
