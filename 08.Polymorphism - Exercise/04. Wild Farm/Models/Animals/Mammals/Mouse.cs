using System;
using System.Collections.Generic;
using System.Linq;
using WildFarm.Models.Foods;

namespace WildFarm.Animals.Mammals
{
    public class Mouse : Mammal
    {
        private const double weightMultiplier = 0.10;
        private readonly ICollection<Type> prefferedFoods;

        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
            prefferedFoods = new List<Type>()
            {
                typeof(Vegetable), typeof(Fruit)
            };
        }

        public override double WeightMultiplier => weightMultiplier;

        public override ICollection<Type> PrefferedFoods => prefferedFoods.ToList().AsReadOnly();

        public override string ProduceSound()
        {
            return "Squeak";
        }

        public override string ToString()
        {
            return base.ToString() + $"{Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
