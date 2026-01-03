namespace Generic_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<Book> lEmp = new List<Book>();

            Book b1 = new Book();
            b1._bid = 1;
            b1._name= "flies";
            b1._authour="M.s.shastri";

            Book b2 = new Book();
            b2._bid = 2;
            b2._name= "happy mind";
            b2._authour="b.s rtr";

            Book b3 = new Book();
            b3._bid = 3;
            b3._name= "wings of dreams";
            b3._authour="kale";

            lEmp.Add(b1);
            lEmp.Add(b2);       
            lEmp.Add(b3);

            foreach(Book b in lEmp) 
                {
                  Console.WriteLine($"ID:{b._bid}, NAME:{b._name} author:{b._authour}");
                }

            Console.WriteLine("From dictionary Demo");
            Dictionary<int, Book> bDict = new Dictionary<int, Book>();
            bDict.Add(b1._bid, b1);
            bDict.Add(b2._bid, b2);
            bDict.Add(b3._bid, b3);

            foreach(KeyValuePair<int,Book> ele in bDict)
            {
                Console.WriteLine($"{ele.Key} and the value is {ele.Value._bid} {ele.Value._name}  {ele.Value._authour}");
            }


        }
    }

    internal class Book
    {
        private int bid;
        private string name;
        private string authour;



        public int _bid
        {
            get { return bid; }
            set { bid = value; }
        }


        public string _name
        {
            get { return name; }
            set { name = value; }
        }


        public string _authour
        {
            get { return authour; }
            set { authour = value; }
        }



    }

}
