namespace SingletonDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello From SingleTonDemo");
            while (true)
            {
             
                Console.WriteLine("Enter the choice for Database 1:MySql 2:MSsQL 3:Oracle");
                int choice = Convert.ToInt32(Console.ReadLine());
                DatabaseFactory dbFactory = new DatabaseFactory();
               Database db =  dbFactory.getDatabaseObj(choice);
                while (true)
                {
                    Console.WriteLine("Enter the choice for 1:insert 2:Update 3:Delete");
                    int choice1 = Convert.ToInt32(Console.ReadLine());
                    switch (choice1)
                    {
                        case 1:
                            db.insert();
                            break;

                        case 2:
                            db.update();
                            break;

                        case 3:
                            db.delete();
                            break;

                        default:
                            Console.WriteLine("You Have Entered the Wrong Choice");

                            break;

                    }
                    Console.WriteLine("Do you want to continue with the selected database enter y/n?");
                    string ans = Console.ReadLine();
                    if (ans=="n")
                    {
                        break;
                    }
                }
                Console.WriteLine("Do you want to continue enter y/n?");
                string ans1 = Console.ReadLine();
                if (ans1=="n")
                {
                    break;
                }
            }
        }

    }

    internal class DatabaseFactory
    {
        internal Database getDatabaseObj(int choice)
        {
            Database db = null;
            switch(choice)
            {
                case 1:
                   db =new MySql();
                    break;

                case 2:
                    db =new MsSql();
                    break;

                case 3:
                    db =new Oracle();
                    break;

                default:
                    Console.WriteLine("YOU have entered wrong choice");
                    break;

            }
            return db;

        }
    }

    internal class Oracle : Database
    {
        protected override void DoDelete()
        {
            Console.WriteLine("data deleted in Oracle successfully...");
        }

        protected override void DoInsert()
        {
            Console.WriteLine("data inserted in Oracle successfully...");
        }

        protected override void DoUpdate()
        {
            Console.WriteLine("data updated in Oracle successfully...");
        }

        protected override string getDbName()
        {
           return "Oracle";
        }
    }

    internal class MsSql : Database
    {
        protected override void DoDelete()
        {
           Console.WriteLine("data deleted in MsSql successfully...");
        }

        protected override void DoInsert()
        {
            Console.WriteLine("data inserted in MsSql successfully...");
        }

        protected override void DoUpdate()
        {
            Console.WriteLine("data updated in MsSql successfully...");
        }

        protected override string getDbName()
        {
            return "MsSql";
        }
    }

    internal class MySql : Database
    {
        protected override void DoDelete()
        {
            Console.WriteLine("data deleted in MySql successfully...");
        }

        protected override void DoInsert()
        {
            Console.WriteLine("data inserted in MySql successfully...");
        }

        protected override void DoUpdate()
        {
            Console.WriteLine("data updated in MySql successfully...");
        }

        protected override string getDbName()
        {
            return "MySql";
        }
    }

    internal abstract class Database
    {
        public Logger _logger = null;
        protected Database()
        {
            _logger= Logger.getLogger();
        }
        protected abstract void DoInsert();
        protected abstract void DoUpdate();
        protected abstract void DoDelete();

        protected abstract string getDbName();

        public void insert()
        {
            DoInsert();
            _logger.log($"insert into {getDbName()} is done");
        }

        public void update()
        {
            DoUpdate();
            _logger.log($"update in {getDbName()} is done");
        }

        public void delete()
        {
            DoDelete();
            _logger.log($"delete from {getDbName()} is done");
        }
    }

    public class Logger
    {

        private static readonly Logger _logger=new Logger();

        private Logger()
        {
            Console.WriteLine("Object get created only once");
        }

        public static Logger getLogger()
        {
            return _logger;
        }

        public void log(string message) 
            {
              Console.WriteLine("Logged at {0}, message: {1}",DateTime.Now.ToString(),message);

            }

    }
}
