using System;
using System.Collections.Generic;
using System.Linq;
using WildFarm.Models.Foods;

namespace WildFarm.Animals.Mammals.Felines
{
    public class Cat : Feline
    {
        private const double weightMultiplier = 0.30;
        private readonly ICollection<Type> prefferedFoods;

        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
            prefferedFoods = new List<Type>()
            {
                typeof(Vegetable), typeof(Meat)
            };
        }

        public override double WeightMultiplier => weightMultiplier;

        public override ICollection<Type> PrefferedFoods => prefferedFoods.ToList().AsReadOnly();

        public override string ProduceSound()
        {
            return "Meow";
        }

        public override string ToString()
        {
            return base.ToString() + $"{Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
