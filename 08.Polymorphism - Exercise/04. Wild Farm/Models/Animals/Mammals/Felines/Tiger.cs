using System;
using System.Collections.Generic;
using System.Linq;
using WildFarm.Models.Foods;

namespace WildFarm.Animals.Mammals.Felines
{
    public class Tiger : Feline
    {
        private const double weightMultiplier = 1.00;
        private readonly ICollection<Type> prefferedFoods;

        public Tiger(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
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
            return "ROAR!!!";
        }

        public override string ToString()
        {
            return base.ToString() + $"{Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
