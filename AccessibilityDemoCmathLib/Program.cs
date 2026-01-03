namespace AccessibilityDemoCmathLib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from Accessibility Demo");

            Cmath C1 = new Cmath();
            C1.add(2,3);
            C1.square(2);
            C1.Div(2, 4);

            AdvancedMath aMath = new AdvancedMath();
            aMath.getData();

            CAdMath cd1 = new CAdMath();
            cd1.add(2,3);
            cd1.square(2);
            cd1.Div(2, 4);
            cd1.GetWrapper(3,5);
        }
    }

    public class Cmath
    {

        //public Access Modifier
        public void add(int x, int y)
        {
            Console.WriteLine($"the add is {x+y}");
        }

        //private access Modifier
        private void sub(int x, int y)
        {
            Console.WriteLine($"The sub is {x-y}");
        }

        //protected access Modifier
        protected void mul(int x, int y)
        {
            Console.WriteLine($"the mul is {x*y}");
        }

        internal void square(int x)
        {
            Console.WriteLine($"the square is {x*x}");
        }

        protected internal void Div(int x, int y)
        {
            Console.WriteLine($"the div is {x/y}");
        }

    }

    public class AdvancedMath : Cmath
    {
        public void getData()
        {
            base.add(1, 2);
            base.Div(1, 2);
            base.mul(1, 2);
            base.square(2);
            
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

