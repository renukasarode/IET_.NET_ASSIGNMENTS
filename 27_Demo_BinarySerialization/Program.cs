using System.Runtime.Serialization.Formatters.Binary;

namespace _27_Demo_BinarySerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from BinarySerialization");
            string filePath = @"C:\Users\IET\Desktop\.Net\27_Demo_BinarySerialization\binaryEmp.txt";
            FileStream fs = null;
            if (File.Exists(filePath))
            {
                fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            }
            else
            {
                fs = new FileStream(filePath,FileMode.OpenOrCreate,FileAccess.Write);
            }

            BinaryFormatter bf = new BinaryFormatter();
        }
    }
}
