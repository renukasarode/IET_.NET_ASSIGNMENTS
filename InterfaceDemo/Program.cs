namespace InterfaceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello From Interface Demo");

            Icalc1 c1 = new operation();

            Icalc2 c2 = new operation();
            c1.add(1,2);
            c1.mul(3,4);

            c2.add(2,3);
            c2.div(2, 1);
            

        }


    }
}
