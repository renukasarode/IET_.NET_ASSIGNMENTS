namespace PropertiesGetSetDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello From properies Demo");
            Employee emp = new Employee();
            //internally calls the set method of employee class
            emp.eid=1;

            //internally calls the get method of employee class
            Console.WriteLine($"the value of eid is {emp.eid}");
            emp.ename="happpy";
            Console.WriteLine($"The name of the Employee is {emp.ename}");
        }

        internal class Employee
        {
            private int eId;
            private string eName;

            public int eid
            {
                get
                {
                    return eId;
                }
                set
                {
                    eId = value;
                }
            }

            public string ename
            {
                get
                {
                    return eName;
                }
                set
                {
                    if(value!=null)
                    {
                        eName = "mr/mrs "+value;
                    }
                    else
                    {
                        eName="invalid Syntax";
                    }
                    
                }
            }
        }
    }
}
