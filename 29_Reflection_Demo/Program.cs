using System.Reflection;

namespace _29_Reflection_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            string filePath = @"C:\Users\IET\Desktop\.Net\30_Demo_CmathDemo\bin\Debug\net8.0\30_Demo_CmathDemo.dll";
            Assembly assembly = Assembly.LoadFrom(filePath);
            Type[] types = assembly.GetTypes();
            foreach (Type type in types)
            {
                Console.WriteLine(type);
               Object dynamicallyCreatedObject = assembly.CreateInstance(type.FullName);

                string methodSignature = "";
                MethodInfo[] methods = type.GetMethods();
                foreach (MethodInfo method in methods) 
                    {
                    //Console.WriteLine($"{method.Name}");
                    methodSignature = method.ReturnType.ToString() +" "+method.Name+"(";

                    ParameterInfo[] parameters = method.GetParameters();
                    foreach(ParameterInfo parameter in parameters)
                    {
                        methodSignature+=parameter.ParameterType.ToString()+" "+parameter.Name+",";

                    }
                    methodSignature = methodSignature.TrimEnd(',')+")";
                    Console.WriteLine($"methodSignature is {methodSignature}");
                    Object[] inputValues = new object[parameters.Length];
                    int i = 0;
                    foreach(ParameterInfo parameter in method.GetParameters())
                    {
                        Console.WriteLine($"Enter the value for {parameter.Name} of type {parameter.ParameterType}");
                        inputValues[i++] = Convert.ChangeType(Console.ReadLine(), parameter.ParameterType);
                        Object? result = type.InvokeMember(
                            method.Name,
                            BindingFlags.Public |
                            BindingFlags.Instance
                            | BindingFlags.InvokeMethod,
                            null,
                            dynamicallyCreatedObject,
                            inputValues);
                      
                        Console.WriteLine($"the {method.Name} the Result is {result}");
                    }
                   
                }
            }
        }
    }
}
