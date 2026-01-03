using System.Security.Cryptography;
using System.Text.Json;
using System.Xml.Serialization;

namespace _28_Demo_Serialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from Serialization Demo");

            String filepath = @"C:\Users\IET\Desktop\.Net\28_Demo_Serialization\empSerialize.xml";
            String filepath1 = @"C:\Users\IET\Desktop\.Net\28_Demo_Serialization\jsonSerialize.json";
            Employee emp = new Employee();
            emp._eID = 1;
            emp._name = "Trtrt";
            emp._salary= 121224.4343;
            FileStream fs = null;
            #region XmlSerialization
            //if(File.Exists(filepath)) 
            //    {
            //      fs = new FileStream(filepath, FileMode.Append, FileAccess.Write);
            //    }
            //else
            //   { 
            //     fs = new FileStream(filepath,FileMode.OpenOrCreate,FileAccess.Write);
            //   }

            //XmlSerializer serializer = new XmlSerializer(typeof(Employee));
            //serializer.Serialize(fs, emp);
            //fs.Close();
            //Console.WriteLine("done"); 
            #endregion

            #region XmlDeserialization

            //if (File.Exists(filepath))
            //{
            //    fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            //}
            //else
            //{
            //    Console.WriteLine("File does not exists");
            //}

            //XmlSerializer serializer = new XmlSerializer(typeof(Employee));
            //Employee emp1 = serializer.Deserialize(fs) as Employee;
            //fs.Close();
            //Console.WriteLine("File read Successfully");
            //Console.WriteLine($"id:{emp1._eID} name:{emp1._name} salary:{emp1._salary}");

            #endregion

            #region json Serialization
            //FileStream fs = null;
            //if (File.Exists(filepath))
            //{
            //    fs = new FileStream(filepath1, FileMode.Append, FileAccess.Write);
            //}
            //else
            //{ 
            //    fs = new FileStream(filepath1,FileMode.OpenOrCreate, FileAccess.Write);
            //}

            //JsonSerializer.Serialize<Employee>(fs, emp);
            //fs.Close();
            //Console.WriteLine("Done");


            #endregion

            #region json Deserialization
            if(File.Exists(filepath)) 
                {
                  fs = new FileStream(filepath1, FileMode.Open,FileAccess.Read);
                }
            else
            {
                Console.WriteLine("File does not Exists");
            }

            Employee emp1 = JsonSerializer.Deserialize<Employee>(fs) as Employee;
            Console.WriteLine("File Read Successfully!!!");
            Console.WriteLine($"The Employee is Eid:{emp1._eID} eName:{emp1._name} salary:{emp1._salary}");

            #endregion



        }
    }

    public class Employee
    {
        private int eID;
        private string name;
        private double salary;

        public int _eID
        {
            get { return eID; }
            set { eID = value; }
        }

        public string _name
        {
            get { return name; }
            set { name = value; }
        }

        public double _salary
        {
            get { return salary; }
            set { salary = value; }
        }



    }
}
