
namespace _40_Demo_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello, World!");

            List<Employee> list = new List<Employee> 
                (
                  new Employee() {eid=1,ename="ayur",address="pune" },
                  new Employee() { eid=2, ename="ayur", address="pune" },
                  new Employee() { eid=3, ename="ayur", address="pune" },
                  new Employee() { eid=4, ename="ayur", address="pune" },
                  new Employee() { eid=5, ename="ayur", address="pune" }
                );
            Console.WriteLine("Enter the initial of city of employee");
            string ch? = Console.ReadLine();

            Predicate<Employee> _predicate = emp => emp.address.ToLower().StartsWith(ch);
            List<int> FilteredList = new List<int>();
            foreach (Employee emp in list) 
                {
                  if(_predicate(emp))
                  {
                    FilteredList.Add(emp);
                  }
                }
        }
    }

    public class Employee
    {
        public int eid { get; set; }
        public string ename { get; set; }

        public string address { get; set; }
    }

}
