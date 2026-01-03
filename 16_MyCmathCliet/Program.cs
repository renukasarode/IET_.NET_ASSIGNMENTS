using _15Demo_CmathLib;

namespace _16_MyCmathCliet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello from Accessibility Demo");

            Cmath C1 = new Cmath();
            C1.add(2, 3);
            // C1.square(2);
            // C1.Div(2, 4);

            Console.WriteLine("in advanced Math methods");
            AdvancedMath aMath = new AdvancedMath();
            aMath.getData();

            CAdMath cd1 = new CAdMath();
            cd1.add(2, 3);
          //  cd1.square(2);
           // cd1.Div(2, 4);
            cd1.GetWrapper(3, 5);
        }
    }

    public class CAdMath : Cmath
    {
        public void GetWrapper(int x, int y)
        {
            base.mul(x, y);
        }
    }
}
