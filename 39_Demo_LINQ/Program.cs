namespace _39_Demo_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Emp> emps = new List<Emp>()
            {
                new Emp(){eid=1,eName="abc",address="pune"},

                new Emp(){eid=2,eName="rtrt",address="pune"},

                new Emp(){eid=3,eName="rtrtrtrt",address="pune"},

                new Emp(){eid=4,eName="rtrt",address="pune"}
            };
            Console.WriteLine("Enter the Employee City");

            string? city = Console.ReadLine()?.ToLower();

            Predicate<Emp> _predicate = emp => emp.address.ToLower()==city;
            foreach (Emp emp in emps) 
                {
                  if(_predicate(emp))
                {
                    Console.WriteLine($"id: {emp.eid} ename={emp.eName} address:{emp.address}");
                }
                }
        }
    }

    internal class Emp
    {
        public int eid { get; set; }
        public string eName { get; set; }
        public string address { get; set; }
    }
}
