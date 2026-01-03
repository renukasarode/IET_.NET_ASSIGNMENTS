using System.Collections;

namespace _20_Demo_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Object[] objArr = new object[5];
            Employee emp = new Employee();
            emp.Eid=2;
            emp.eName="rtrtr";
            emp.eAdd="pune";
            objArr[0] = 1;
            objArr[1] = "hello from Collection Demo";
            objArr[2] = true;
            objArr[3] = emp;
            objArr[4] = 't';


            //foreach (Object obj in objArr)
            //{
            //    Console.WriteLine(obj.GetType().ToString());
            //    if (obj.GetType().ToString()=="Sytem.Int32")
            //    {
            //        int j = Convert.ToInt32(obj);
            //        Console.WriteLine($"The value {j} is of type: {obj.GetType().ToString()}");
            //    }
            //}

            foreach(Object obj in objArr)
            {
                if(obj is int)
                {
                    int j = Convert.ToInt32(obj);
                    Console.WriteLine($"the value of {j} of type {obj.GetType().ToString()}");
                }
                if(obj is string)
                {
                    string str = Convert.ToString(obj);
                    Console.WriteLine($"the value of {str} of type {obj.GetType().ToString()}");
                }

                if(obj is Boolean)
                {
                    Boolean b = Convert.ToBoolean(obj);
                    Console.WriteLine($"the value of {b} of type {obj.GetType().ToString()}");
                }
                if(obj is Employee)
                {
                    Employee e = (Employee)obj;
                    Console.WriteLine($"the value of employee: id:{e.Eid} eName:{e.eName} Address:{e.eAdd} of type {obj.GetType().ToString()}");                
                }

                if(obj is char)
                {
                    char t = Convert.ToChar(obj);
                    Console.WriteLine($"the value of {t} of type is {obj.GetType().ToString()}");
                }


                     
            }

            ArrayList aList = new ArrayList();
            Employee emp1 = new Employee();

            emp1.Eid=1;
            emp1.eName="rtrrtrtr";
            emp1.eAdd="pune";

            aList.Add(1);
            aList.Add("String");
            aList.Add(emp1);

            foreach(Object obj in aList)
            {
                if (obj is int)
                {
                    int j = Convert.ToInt32(obj);
                    Console.WriteLine($"the value of {j} is of type {obj.GetType().ToString()}");
                }
                if(obj is string)
                {
                    string str = Convert.ToString(obj);
                    Console.WriteLine($"the value of {str} of type {obj.GetType().ToString()}");
                }

                if(obj is Employee)
                {
                    Employee e = (Employee)obj;
                    Console.WriteLine($"the value of employee: eid: {e.Eid} ename:{e.eName} eADD:{e.eAdd} of type {obj.GetType().ToString()}");
                }
            }
        }
    }

    public class Employee
    {
        private int id;
        private string name;
        private string address;

        public int Eid
        {
            get { return id; }
            set { id = value; }
        }
       
        public string eName
        {
            get { return name; }
            set { name = value; }
        }


        public string  eAdd
        {
            get { return address; }
            set { address = value; }
        }

    }

}
