using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    internal class KitchenRobot
    {
        public string Recipe { get; set; }

        public string[] Ingredients { get; set; }
        public void SetRecipe(string recipe)
        {
            Recipe = recipe;
        }

        public void AddIngredients(string[] ingredients)
        {
            Ingredients = ingredients;
        }

        public void Action()
        {
            if (Recipe != null && Ingredients != null)
            {
                Console.WriteLine($"Today's recipe is {Recipe}");
                Console.WriteLine($"Ingredients that we will use are {Ingredients[0]} and {Ingredients[1]}");
            }
            else
            {
                Console.WriteLine("Recipe or ingredients are missing!");
            }
        }
    }
}
