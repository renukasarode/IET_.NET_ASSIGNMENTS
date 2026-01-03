using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopInterfaceFactoryPattern
{
    internal interface Idatabase
    {
        public void insert();
        public void update();
        public void delete();

    }

    internal class Factory
    {
        public Idatabase GetDatabaseObj(int choice)
        {
            Idatabase db = null;
            switch (choice)
            {
                case 1:
                    db=new MsSql();
                    break;
                case 2:
                    db=new Mysql();
                    break;
                case 3:
                    db=new Oracle();
                    break;

                case 4:
                    Console.WriteLine("Thank You for Visiting...");
                    break;

                default:
                    Console.WriteLine("You have entered wrong choice");
                    break;
            }
            return db;
        }
    }

        internal class Mysql() : Idatabase
        {
            public void delete()
            {
                Console.WriteLine("data deleted from mySql successfully");
            }

            public void insert()
            {
                Console.WriteLine("data inserted from mySql successfully");
            }

            public void update()
            {
                Console.WriteLine("data updated from mySql successfully");
            }
        }

        internal class MsSql : Idatabase
        {
            public void delete()
            {
                Console.WriteLine("data deleted from msSql successfully");
            }

            public void insert()
            {
                Console.WriteLine("data inserted from msSql successfully");
            }

            public void update()
            {
                Console.WriteLine("data updated from msSql successfully");
            }
        }

        internal class Oracle : Idatabase
        {
            public void delete()
            {
                Console.WriteLine("data deleted from oracle successfully");
            }

            public void insert()
            {
                Console.WriteLine("data inserted from oracle successfully");
            }

            public void update()
            {
                Console.WriteLine("data updated from oracle successfully");
            }
        }
}

