using System;
using System.Collections.Generic;
using WildFarm.Exceptions;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals
{
    public abstract class Animal
    {

        public Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }


        public string Name { get; protected set; }

        public double Weight { get; protected set; }

        public int FoodEaten { get; protected set; }

        public abstract ICollection<Type> PrefferedFoods { get; }

        public abstract double WeightMultiplier { get; }


        public abstract string ProduceSound();

        public void Feed(Food food)
        {
            if(!PrefferedFoods.Contains(food.GetType()))
            {
                string msg = string.Format(ExceptionMessages.InvalidFoodType, GetType().Name, food.GetType().Name);
                throw new Exception(msg);
            }

            Weight += WeightMultiplier * food.Quantity;
            FoodEaten += food.Quantity;
        }

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, ";
        }
    }
}
