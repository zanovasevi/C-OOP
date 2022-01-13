using System;
using System.Collections.Generic;
using System.Linq;
using WildFarm.Models.Foods;

namespace WildFarm.Animals.Mammals
{
    public class Dog : Mammal
    {
        private const double weightMultiplier = 0.40;
        private readonly ICollection<Type> prefferedFoods;

        public Dog(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
            prefferedFoods = new List<Type>()
            {
                typeof(Meat)
            };
        }

        public override double WeightMultiplier => weightMultiplier;

        public override ICollection<Type> PrefferedFoods => prefferedFoods.ToList().AsReadOnly();

        public override string ProduceSound()
        {
            return "Woof!";
        }

        public override string ToString()
        {
            return base.ToString() + $"{Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
