using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInheritanceDemo
{
    internal class HotDrink : Idrink
    {
        public void Drink()
        {
            Console.WriteLine("Enjoy your HotDrink");
        }
    }
}
