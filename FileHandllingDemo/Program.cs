using System.Diagnostics.Tracing;

namespace FileHandllingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string filePath = @"C:\\Users\\IET\\Desktop\\.Net\\FileHandllingDemo\fileDemo.txt";
            string filePath1 = @"C:\\Users\\IET\\Desktop\\.Net\\FileHandllingDemo\emp.txt";
            #region file Write
            //FileStream fs = null;
            //if (File.Exists(filePath))
            //{
            //    fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            //}
            //else
            //{
            //    fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            //}

            //StreamWriter writer = new StreamWriter(fs);
            //writer.WriteLine("Hello from first file handling demo");
            //writer.Flush();
            //writer.Close();
            //fs.Close();
            //Console.WriteLine("done");
            //Console.WriteLine("Hello, World!");
            #endregion

            #region file reading
            //FileStream fs1 = null;
            //if(File.Exists(filePath)) 
            //    {
            //    fs1 = new FileStream(filePath,FileMode.Open, FileAccess.Read);
            //    }
            //else
            //{
            //    Console.WriteLine("file does not  exists");
            //}

            //StreamReader reader = new StreamReader(fs1);
            //string content = reader.ReadToEnd();
            //reader.Close();
            //fs1.Close();
            //Console.WriteLine(content);
            #endregion

            Employee emp = new Employee();
            emp.id= 1;
            emp._name="greart";
            emp.eSalary=1234344;

            FileStream fs = null;
            if(File.Exists(filePath))
            {
                fs = new FileStream(filePath1, FileMode.Append,FileAccess.Write);
            }
            else
            {
                fs = new FileStream(filePath1, FileMode.OpenOrCreate,FileAccess.Write);
            }

            StreamWriter writer = new StreamWriter(fs);
             writer.WriteLine(emp);
            writer.Flush();
            writer.Close();
            fs.Close();
            Console.WriteLine("done...");







        }
    }

    internal class Employee
    {
        private int eID;
        private string name;
        private int salary;

        public int id
        {
            get { return eID; }
            set { eID = value; }
        }

        public string _name
        {
            get { return name; }
            set { name = value; }
        }

        public int eSalary
        {
            get { return salary; }
            set { salary = value; }
        }
    }
}
