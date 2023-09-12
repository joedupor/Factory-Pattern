namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Welcome to The Food Factory today! Please place your order (burger, pizza, hot dog) here:");
            string customerResponse = Console.ReadLine();

            IFastFood customerOrder = FoodFactory.GetOrder(customerResponse);
            Console.WriteLine("--------------------------");
            customerOrder.MenuItemDescrp();    //this is instanceName.MethodName();
            Console.WriteLine();
            
            Console.WriteLine($"That will be ${customerOrder.Price}");
            Console.WriteLine($"MealDeal included: {customerOrder.MealDeal}");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Enjoy your meal!");

        }
    }
}
