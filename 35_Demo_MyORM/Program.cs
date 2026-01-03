using _34_demo_CustomizedAttribute;
using System.Reflection;

namespace _35_Demo_MyORM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, From ORM demo");
            string path = @"C:\\Users\\IET\\Desktop\\.Net\\33_Demo_EmpLib\\bin\\Debug\\net8.0\33_Demo_EmpLib.dll";
            Assembly assembly = Assembly.LoadFrom(path);
            Type [] types = assembly.GetTypes();
            foreach (Type type in types) 
                {
                Console.WriteLine($"type is {type.FullName}");
                String createTableQuery = "CREATE TABLE ";
                Attribute[] attributesArr = type.GetCustomAttributes().ToArray();
                foreach (Attribute attribute in attributesArr) 
                    {
                     Console.WriteLine($"attribute is {attribute}");
                    //Console.WriteLine(attribute is TableAttribute);
                    if(attribute is TableAttribute)
                    {
                        //Console.WriteLine("in table");
                        TableAttribute table = attribute as TableAttribute;
                        createTableQuery+=table._tableName +"(";

                        //create table Employee 

                    }

                    }


                PropertyInfo[] properties =  type.GetProperties();
                foreach(PropertyInfo property in properties) 
                    {
                    //Console.WriteLine(property);
                    Attribute[] atts =  property.GetCustomAttributes().ToArray();
                    foreach(Attribute attribute in atts)
                    {
                        //Console.WriteLine(attribute);
                        if(attribute is ColumnAttribute)
                        {
                            ColumnAttribute column = attribute as ColumnAttribute;
                            createTableQuery+= column.columnName+" "+column.columnType +",";
                        }
                    }

                }
                createTableQuery = createTableQuery.TrimEnd(',')+")";
                Console.WriteLine($"query is {createTableQuery}");
                string filePath = @"C:\Users\IET\Desktop\.Net\35_Demo_MyORM\SQL_Query\sqlQueries.sql";
                File.WriteAllText(filePath, createTableQuery);
                Console.WriteLine("Done");
            }


        }
    }

  
}
