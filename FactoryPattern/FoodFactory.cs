using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal static class FoodFactory
    {

        public static IFastFood GetOrder(string custChoice)
        {   
            switch (custChoice)
            {
                case "hot dog":
                    return new HotDog();
                case "pizza":
                    return new Pizza();
                case "burger":
                    return new Burger();
                default:
                    return new HotDog();
            }

        }
    }
}
