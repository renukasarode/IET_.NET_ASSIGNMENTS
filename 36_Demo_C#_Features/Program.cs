
using System;
using System.Security.Cryptography.X509Certificates;

namespace _36_Demo_C__Features
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Partial class
            ////Console.WriteLine("Hello, World!");
            //CMath m1 = new CMath();
            //Console.WriteLine($"multi is: {m1.multiply(1, 4)}");
            //Console.WriteLine($"add is: {m1.add(1, 4)}"); 
            #endregion

            #region Nullable operator
            //String name = null;

            //int? DeptId = null;
            //int? DeptID = 1234;
            //if (DeptID.HasValue)
            //{
            //    Console.WriteLine(DeptID.Value);
            //}
            //else
            //{
            //    Console.WriteLine("deptId = null");
            //}

            //Nullable<int> dpt = null;
            //Nullable<int> dpt1 = 3456;
            //if (dpt1.HasValue)
            //{
            //    Console.WriteLine(dpt1.Value);
            //}
            //else
            //{
            //    Console.WriteLine("dpt1.Value value is null");
            //}
            #endregion

            #region Object Initializer
            //Demo d1 = new Demo()
            //{
            //    _id = 10
            //};
            //Console.WriteLine($"id is {d1._id}");

            //Demo d2 = new Demo()
            //{
            //    _id = 10,
            //    _name="rtrt",
            //    _desc="deccan"
            //};
            //Console.WriteLine($"id: {d2._id} name:{d2._name} description:{d2._desc}");
            #endregion

            #region Collection Demo
            //int[] arr = { 1, 2, 3 };
            //string[] name = {"abc","xyz","sdsd","dffd"};

            //Console.WriteLine("for array of integer");
            //for(int i=0;i<arr.Length;i++) 
            //    {
            //      Console.WriteLine(arr[i]);
            //    }

            //Console.WriteLine("for array of string");
            //for (int i = 0; i<name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            //Console.WriteLine("for list of demos");
            //List<Demo> demos = new List<Demo>()
            //{
            //    new Demo() {_id=1,_name="rtrrtr",_desc="happy"},
            //     new Demo() {_id=2,_name="rtr",_desc="happy birthday"},
            //      new Demo() {_id=3,_name="rtrtrt",_desc="happy desc"}
            //};

            // foreach(Demo demo in demos) 
            //    {
            //    Console.WriteLine($"id: {demo._id} name:{demo._name} description:{demo._desc}");
            //}

            #endregion

            #region Auto Properties
            //Employee e1 = new Employee()
            //{
            //    ID=1,
            //    name="renuka",
            //    isActive=true,
            //    salary=50000,
            //    dOJ=DateTime.Now,
            //    projects=new List<string>
            //    {
            //        "asp .Net","ms","hibernate orm"
            //    },
            //    demo=new Demo() { _id=1, _name="hello", _desc="best" },

            //};

            //Console.WriteLine($"e1: id: {e1.ID} name:{e1.name}, isActive:{e1.isActive}" +
            //    $"salary:{e1.salary}");
            //foreach(string p in e1.projects) 
            //{
            //    Console.WriteLine($"The Projects are:{p}");
            //}
            #endregion

            #region Implicit Type
            // Test t1 = new Test();
            //int value =  Convert.ToInt32(t1.DoSomething(1));
            // Console.WriteLine($"value is {value}");
            // Console.WriteLine(value.GetType().ToString());

            // Employee e1 = (Employee)t1.DoSomething(2);
            // Console.WriteLine($"Employee: id={e1.ID} name:{e1.name} salary:{e1.salary} isActive:{e1.isActive} doj:{e1.dOJ}");
            // Object obj = t1.DoSomething(null);
            // Console.WriteLine($"OBJ is null {obj}");

            // var i = 10;
            // //var k;  not allowed cte
            // var emp = new Employee() { ID=1, name="rrtrrt", salary=10000 };
            // Console.WriteLine($"the emp is id {emp.ID} name {emp.name} salary={emp.salary}");
            // Console.WriteLine(emp.GetType().ToString());

            // var obj1 = new Object();
            // Console.WriteLine(obj1.GetType().ToString());


            // Console.WriteLine("Enter the value for obj3");
            // var dyInput = Console.ReadLine();
            // Console.WriteLine($"the value of dyInput {dyInput}");

            #endregion

            #region Annonymous Types
            List<Holder> dbHolder = new List<Holder>()
            {
               new Holder(){id=1,name="rtrtr",address="pune"},
               new Holder(){id=2,name="rtrtr",address="deccan"}
            };

            var h1 = new Holder() { id=1, name="rtrtr", address="pune" };
            Console.WriteLine($"h1 type is {h1.GetType().ToString()}");
            var h2 = new Holder() { id=2,address="deccan",name="rtrtrt" };
            Console.WriteLine($"h2 type is {h2.GetType().ToString()}");


            //annonymous class
            var h3 = new {id=3,name="rtrt",address="pune deccan"};
            Console.WriteLine($"h3 type is {h3.GetType().ToString()}");

            var h4 = new { id = 4, name = "rtrt", address = "pune deccan" };
            Console.WriteLine($"h4 type is {h4.GetType().ToString()}");

            var h5 = new { id = 5, address = "pune deccan" , name = "rtrt"};
            Console.WriteLine($"h5 type is {h5.GetType().ToString()}");

            //by changing the dataType only...........
            var h6 = new { id = 5, address = true, name = "rtrt" };
            Console.WriteLine($"h6 type is {h6.GetType().ToString()}");

            //h6.address = false; it is read only
            Console.WriteLine(h6.address);
            Console.WriteLine($"h6.address type is {h6.address.GetType().ToString()}");

            var h7 = new { cid = 1, cName = "happy" };
            Console.WriteLine($"the cid: {h7.cid} and name is {h7.cName}");
            Console.WriteLine($"the type of h7 is {h7.GetType().ToString()}");
            #endregion
        }

    }

    internal class Holder
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }

    }

    internal class Employee
    {
        public int ID { get; set; }
        public string name { get; set; }
        public Boolean isActive { get; set; }
        public double salary { get; set; }
        public DateTime dOJ { get; set; }
        public List<string> projects { get; set; }

        public Demo demo { get; set; }
    }

    public class Demo
    {
        private int id;

        public int _id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string _name
        {
            get { return name; }
            set { name = value; }
        }

        private string description;

        public string _desc
        {
            get { return description; }
            set { description = value; }
        }



    }

    public class Test
    {
        public Object DoSomething(Nullable<int> choice)
        {
            if(choice==1)
            {
                return 1;
            }
            else if(choice==2)
            {
                return new Employee() { ID=1, name="best", salary=120000, dOJ=DateTime.Now,isActive=true};
            }
            else 
            {
                return null;
            }
        }
    }
}
