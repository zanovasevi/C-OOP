using System;
using WildFarm.Exceptions;
using WildFarm.Models.Foods;

namespace WildFarm.Factories
{
    public class FoodFactory
    {
        public Food CreateFood(string[] secondSplit)
        {
            Food food = null;
            string foodType = secondSplit[0];
            int foodQuantity = int.Parse(secondSplit[1]);

            if (foodType == "Vegetable")
            {
                food = new Vegetable(foodQuantity);
            }
            else if (foodType == "Fruit")
            {
                food = new Fruit(foodQuantity);
            }
            else if (foodType == "Meat")
            {
                food = new Meat(foodQuantity);
            }
            else if (foodType == "Seeds")
            {
                food = new Seeds(foodQuantity);
            }

            return food;
        }
    }
}
