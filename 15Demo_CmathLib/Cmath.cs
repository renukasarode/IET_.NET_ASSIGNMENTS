namespace _15Demo_CmathLib
{
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
