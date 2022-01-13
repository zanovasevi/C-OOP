using System;
using System.Collections.Generic;
using System.Linq;
using WildFarm.Models.Foods;

namespace WildFarm.Animals.Birds
{
    public class Owl : Bird
    {
        private const double weightMultiplier = 0.25;
        private readonly ICollection<Type> prefferedFoods;

        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
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
            return "Hoot Hoot";
        }

        public override string ToString()
        {
            return base.ToString() + $"{WingSize}, {Weight}, {FoodEaten}]";
        }
    }
}
