using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class HotDog : IFastFood
    {
        public bool MealDeal { get; set; } = false;
        public double Price { get; set; } = 6.99;

        public void MenuItemDescrp()
        {
            Console.WriteLine("A classic choice!");

        }
    }
}
