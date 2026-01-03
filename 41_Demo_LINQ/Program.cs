using System.Collections.Generic;

namespace _41_Demo_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region orderBy


            //int[] arr = { 1, 2, 3, 4, 11, 5, 6, 4, 5, 45, 45, 54 };

            //var result = from element in arr
            //             orderby element descending
            //             where element%2==0
            //             select element;

            //foreach (int element in result)
            //{
            //    Console.WriteLine(element);
            //}

            #endregion

            #region Lazy Loading of LINQ

            //List<Employee> list = new List<Employee>()
            //   {
            //      new Employee() { eid=1, ename="abc", address="pune" },
            //      new Employee() { eid=2, ename="abc", address="pune" },
            //      new Employee() { eid=3, ename="abc", address="pune" }
            //    };

            //var result3 = from emp in list
            //              select emp;

            //list.Add(new Employee() { eid=4, ename="abc", address="pune" });

            //foreach (Employee emp in list)
            //{
            //    Console.WriteLine($"id:{emp.eid} name:{emp.ename} adddress:{emp.address}");
            //}

            #endregion

            #region LINQ WITH toList Extension method


            //List<Employee> list1 = new List<Employee>()
            //   {
            //      new Employee() { eid=1, ename="abc", address="pune" },
            //      new Employee() { eid=2, ename="abc", address="pune" },
            //      new Employee() { eid=3, ename="abc", address="pune" }
            //    };

            //var result4 = (from emp in list1
            //              select emp).ToList();


            //list1.Add(new Employee() { eid=4, ename="abc", address="pune" });

            //foreach(Employee emp in result4 ) 
            //    {
            //      Console.WriteLine($"id: {emp.eid} ename:{emp.ename} address: {emp.address}");
            //    }
            #endregion

            #region LINQ WITH Tuple Syntax


            //List<Employee> list2 = new List<Employee>()
            //   {
            //      new Employee() { eid=1, ename="abc", address="pune" },
            //      new Employee() { eid=2, ename="abc", address="pune" },
            //      new Employee() { eid=3, ename="abc", address="pune" }
            //    };

            //var result5 = (from emp in list2
            //               select (emp.ename, emp.address)).ToList();

            //foreach(var element in result5 )
            //{
            //    Console.WriteLine($"name:{element.ename} address:{element.address}");
            //}
            #endregion

            #region Linq with MyHolder class 

            List<Employee> list3 = new List<Employee>()
               {
                  new Employee() { eid=1, ename="abc", address="pune" },
                  new Employee() { eid=2, ename="abc", address="pune" },
                  new Employee() { eid=3, ename="abc", address="pune" }
                };

            var result5 = (from emp in list3
                           select new MyHolder() {name=emp.ename,address=emp.address}).ToList();

            foreach (MyHolder holder in result5)
            {
                holder.getDetails();
                //Console.WriteLine($"name:{holder.name} address:{holder.address}");
            }
            #endregion

        }
    }

    internal class MyHolder
    {
        public string name { get; set; }
        public string address { get; set; }

        public void getDetails()
        {
            Console.WriteLine($"name:{name} address:{address}");
        }
    }
    

    internal class Employee
    {
        public int eid { get; set; }

        public string ename { get; set; }

        public string address { get; set; }
    }
}
