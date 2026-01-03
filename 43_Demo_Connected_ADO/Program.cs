using _43_Demo_Connected_ADO.DAL;
using _43_Demo_Connected_ADO.Models;

namespace _43_Demo_Connected_ADO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IetDbContext dbContext = new IetDbContext();
            int choice = 0;
            while(true)
            {
                Console.WriteLine("Enter your choice: ");

                Console.WriteLine("Enter the choice for \n1:insert\n" +
                    " 2:read\n 3:update\n  4:delete\n 5:getEmpById ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter the employee Name");
                            string name = Console.ReadLine();

                            Console.WriteLine("Enter the employee Address");
                            string address = Console.ReadLine();

                            Emp emp = new Emp() { name=name, address=address };
                           int records =  dbContext.addEmployee(emp);
                            if(records>0)
                            {
                                Console.WriteLine("RECORED ADDED");
                            }
                            else
                            {
                                Console.WriteLine("not added");
                            }
                                break;
                        }
                        case 2:
                        {
                           List<Emp> eList =  dbContext.readAllEmployees();
                            if(eList!=null && eList.Count>0)
                            {
                                foreach(Emp emp in eList)
                                {
                                    Console.WriteLine($"id={emp.eid} name={emp.name} address={emp.address}");
                                }
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter the id of the emp you want to update");
                            int eid = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the updated employee Name");
                            string updatedName = Console.ReadLine();

                            Console.WriteLine("Enter the updated employee Address");
                            string updatedAddress = Console.ReadLine();

                            Emp emp = new Emp() { eid=eid,name=updatedName, address=updatedAddress };

                           int records = dbContext.updateEmployee(emp);
                            if (records>0)
                            {
                                Console.WriteLine("RECORED updated");
                            }
                            else
                            {
                                Console.WriteLine("not updated");
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter the id of the emp you want to delete");
                            int eid = Convert.ToInt32(Console.ReadLine());
                            int records = dbContext.deleteEmployee(eid);
                            if (records>0)
                            {
                                Console.WriteLine("RECORED deleted");
                            }
                            else
                            {
                                Console.WriteLine("not deleted");
                            }
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Enter the id of the emp");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Emp emp = dbContext.getEmpByID(id);
                            if(emp!=null)
                            {
                                Console.WriteLine($"id={emp.eid} name={emp.name} address={emp.address}");
                            }
                            else
                            {
                                Console.WriteLine("not found");
                            }

                                break;
                        }
                    default:
                        {
                            Console.WriteLine("You have Entered the Wrong choice.......");
                            break;
                        }
                 
                }

                Console.WriteLine("Do you want to Continue y/n");
                if (Console.ReadLine()=="n")
                    break;
            }
        }
    }
}
