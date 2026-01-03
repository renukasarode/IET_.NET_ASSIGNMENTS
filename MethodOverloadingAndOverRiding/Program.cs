namespace MethodOverloadingAndOverRiding
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region overLoading
            Console.WriteLine("METHOD overLoading and MethodOverRiding");
            Imath M = new Operation1();
            M.add(1, 2);
            M.add(3, 4, 5);
            M.add(4, 5, 5, 6);

            Imath M1 = new Operation2();
            M1.add(1, 2);
            M1.add(3, 4, 5);
            M1.add(4, 5, 5, 6);
            #endregion

            #region overriding

            CMath m2 = new AdvancedMath();
            m2.add(1, 2,3);
            m2.mul(1, 2);
            m2.sub(1, 2);

            AdvancedMath m3 = new AdvancedMath();
            m3.add(1,2,3,4);
            m3.sub(12, 11);
            m3.mul(1, 2);


            #endregion
        }
    }
}
