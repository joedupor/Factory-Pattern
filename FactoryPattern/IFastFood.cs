using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal interface IFastFood
    { 
        public bool MealDeal { get; set; }

        public double Price { get; set; }

        public void MenuItemDescrp();      //return type was given as void which means it needs to be as such also in all the sub classes.
        

    }
}
