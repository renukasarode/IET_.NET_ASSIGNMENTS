namespace oopInterfaceFactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from oopInterface Factory");
            int choice1 = 0;
            int choice2 = 0;
            do
            {
                Console.WriteLine("Enter the choice of Database 1:msSql 2:MySql 3:Oracle 4:exit");
                choice1 = Convert.ToInt32(Console.ReadLine());
                Factory f = new Factory();
                Idatabase db = f.GetDatabaseObj(choice1);
                if (choice1==4)
                {
                    break;
                }

                do
                {
                Console.WriteLine("Enter you choice for performing the operations on database:" +
                    "1:Insert 2:Update 3:Delete 4:exit");
                choice2 = Convert.ToInt32(Console.ReadLine());
                switch (choice2)
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


                    case 4:
                        Console.WriteLine("thank you for Visiting.....");
                        break;

                    default:
                        Console.WriteLine("You have Entered the Wrong choice");
                        break;
                }
            } while (choice2!=4);
        }
        while(choice1!=4);
        }
    }
}
