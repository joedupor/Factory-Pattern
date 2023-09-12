using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Pizza : IFastFood
    {
        public bool MealDeal { get; set; } = false;
        public double Price { get; set; } = 7.99;

        public void MenuItemDescrp()
        {
            Console.WriteLine("A nice slice of pie!");

        }
        
    }
}
