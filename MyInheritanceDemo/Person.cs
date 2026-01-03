using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInheritanceDemo
{
    internal class Person
    {
        public string firstName;
        public string lastName;

        public Person()
        {
            
        }
    }
    internal class Employee:Person{
        public int empId;

        public Employee()
        {
            
        }
    }
}
