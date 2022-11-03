using Robots;

namespace Robots
{
    public class Program
    {
        static void Main()
        {
            int kitchenCounter = 1;
            int vendingCounter = 1;
            int cleaningCounter = 1;
            IList<CleaningRobot> cleaningRobots = new List<CleaningRobot>()
            {
                new CleaningRobot{Plan = "Kitchen", Mixture = "Vanish"},
                new CleaningRobot{Plan = "Bedroom", Mixture = "Mr.Proper"}
            };
            foreach (CleaningRobot cleaningRobot in cleaningRobots)
            {                
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"\n---------Cleaning Robot{cleaningCounter}---------");
                    cleaningRobot.Action();
                }
                cleaningCounter++;
            }

            IList<KitchenRobot> kitchenRobots = new List<KitchenRobot>()
            {
                new KitchenRobot{Recipe = "Grilled Fish", Ingredients = new string[] {"Spices", "Fish"} },
                new KitchenRobot{Recipe = "Salty Chicken", Ingredients = new string[] {"Salt", "Chicken"} },
                new KitchenRobot{Recipe = null,  Ingredients = new string[] {"Salt", "Chicken"} }                
            };
            foreach (KitchenRobot kitchenRobot in kitchenRobots)
            {
                Console.WriteLine($"\n---------Kitchen Robot{kitchenCounter}---------");
                kitchenRobot.Action();
                kitchenCounter++;
            }

            IList<VendingMachine> vendingMachines = new List<VendingMachine>()
            {
                new VendingMachine{IsEntered = true, Items = new string[] { "Water", "Sandwich", "Socks" }, CurrentItem = "Water" },
                new VendingMachine{IsEntered = true, Items = new string[] { "Soda", "Salad", "Sushi Box" }, CurrentItem = "Socks"},
                new VendingMachine{IsEntered = false, Items = new string[] { "Soda", "Salad", "Sushi Box" }, CurrentItem = "Socks"}
            };
            foreach (VendingMachine vendingMachine in vendingMachines)
            {               
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine($"\n---------Vending Machine{vendingCounter}---------");
                    vendingMachine.Action();
                }
                vendingCounter++;
            }
        }
    }
}