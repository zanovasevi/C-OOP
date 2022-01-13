using System;
using System.Collections.Generic;
using System.Linq;
using WildFarm.Models.Foods;

namespace WildFarm.Animals.Birds
{
    public class Hen : Bird
    {
        private const double weightMultiplier = 0.35;
        private readonly ICollection<Type> prefferedFoods;

        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
            prefferedFoods = new List<Type>()
            {
                typeof(Vegetable), typeof(Fruit), typeof(Meat), typeof(Seeds)
            };
        }

        public override double WeightMultiplier => weightMultiplier;

        public override ICollection<Type> PrefferedFoods => prefferedFoods.ToList().AsReadOnly();

        public override string ProduceSound()
        {
            return "Cluck";
        }

        public override string ToString()
        {
            return base.ToString() + $"{WingSize}, {Weight}, {FoodEaten}]";
        }
    }
}
