using System.Numerics;

namespace BoxingAndUnBoxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from Boxing AND Unboxing");
            int i = 10;
            String str = "hello";
            // BigInteger bigInt = 10;
            String intToStr = Convert.ToString(i);
            Console.WriteLine("the explicit Conversion from intToStr {0}", intToStr);

            //int strToInt = Convert.ToInt32(str

            //int strToInt = Convert.ToInt32(BigInteger.Parse(str));
            //int strToInt = Convert.ToInt32(str);
            //Console.WriteLine("the explicit Conversion from strToInt {0}", strToInt);

            //Object obj = new Object();
            //int refTOInt = Convert.ToInt32(str);
            //Console.WriteLine("the explicit Conversion from strToInt {0}", refTOInt);

            //implicit Boxing
            Object obj = i;
            Console.WriteLine("implicit boxing int to referenceType {0}", obj);
        }
    }
}
