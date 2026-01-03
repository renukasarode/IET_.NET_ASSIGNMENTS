namespace _40_Demo_LINQ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            #region MyRegion

            List<Employee> emps = new List<Employee>()
            {
                new Employee(){Id=1,Name="ayur",address="pune"},
                new Employee(){Id=1,Name="ayur",address="pune"},
                new Employee(){Id=1,Name="ayur",address="pune"},
                new Employee(){Id=1,Name="ayur",address="pune"}
            };
            Console.WriteLine("Enter the employee City Initial character");
            string? ch = Console.ReadLine().ToLower();

            List<Employee> filteredList = new List<Employee>();

            Predicate<Employee> _predicate = emp => emp.address.ToLower().StartsWith(ch);
            foreach (Employee emp in emps)
            {
                if (_predicate(emp))
                {
                    filteredList.Add(emp);
                }
            }
            #endregion

            #region LINQ Language Integrated Query Syntax
            var result = from emp in emps
                         select emp;    

            foreach (Employee emp in filteredList)
            {
                Console.WriteLine($"id: {emp.Id} name:{emp.Name} address:{emp.address}");
            }

            var Result1 = from emp in emps
                         where emp.address.ToLower().StartsWith(ch)
                         select emp.Name;

            foreach (string name in Result1)
            {
                Console.WriteLine($"name:{name}");

            }


            #endregion



        }
    }

    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string address { get; set; }
    }
}
