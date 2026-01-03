namespace MyInheritanceDemo
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            #region inheritanceDemo1
            //Idrink d1 = new ColdDrink();
            //Idrink d2 = new HotDrink();
            //Console.WriteLine("d1",d1);
            //Console.WriteLine("d2",d2);

            //d1.Drink();
            //d2.Drink();
            #endregion
            #region inheritanceDemo2
           // Employee p = new Employee();
           // Console.WriteLine("enter the firstName");
           // String firstName =Console.ReadLine();
           ////p.firstName="rtrrrrrt";
           //p.firstName=firstName;
           // p.lastName="skkkkkkkkss";
           // p.empId=145;
           // Console.WriteLine(p.empId+ " "+ p.firstName + " " +  p.lastName);

            #endregion

            #region constructorChaning and mapping


            Console.WriteLine("in constructorChaing and mapping");
            Derived d = new Derived();
            Derived d1 = new Derived(5);
            d1.method1();
            d1.method2();
            #endregion



        }
    }
}
