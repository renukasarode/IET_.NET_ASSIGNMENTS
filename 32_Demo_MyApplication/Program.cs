using _31_demo_BvsAttribute;
using System.Reflection;

namespace _32_Demo_MyApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string assPath = @"C:\Users\IET\Desktop\.Net\33_Demo_EmpLib\bin\Debug\net8.0/33_Demo_EmpLib.dll";

            Assembly asm = Assembly.LoadFrom(assPath);
            Type[] allTypes = asm.GetTypes();
            for (int i = 0; i < allTypes.Length; i++)
            {
                Type type = allTypes[i];
                //Console.WriteLine(type.Name);
                Attribute[] attr=  type.GetCustomAttributes().ToArray();
                foreach (Attribute attribute in attr)
                {
                   // Console.WriteLine(attribute);
                    if(attribute is BoventureSystemsAttribute)
                    {
                        BoventureSystemsAttribute bvsAttr = (BoventureSystemsAttribute)attribute;
                        //Console.WriteLine("we are in bvs");
                        Console.WriteLine($"the class {type.Name} is developed by {bvsAttr.DeveloperName} of c of company {bvsAttr.CompanyName}");
                    }

                    if (attribute is SerializableAttribute)
                    {
                        Console.WriteLine($"The class {type.Name} marked as Serializable");
                    }
                }
            }
        }
    }
}