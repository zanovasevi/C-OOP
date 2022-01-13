using System;
namespace Pizza_Calories
{
    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private double weight;

        public Dough()
        {
            flourType = "";
            bakingTechnique = "";
            weight = 0;
        }

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
            Weight = weight;
        }


        private string FlourType
        {
            /*get
            {
                return flourType;
            }*/
            set
            {
                if(value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                flourType = value;
            }
        }

        private string BakingTechnique
        {
            /*get
            {
                return bakingTechnique;
            }*/
            set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                bakingTechnique = value;
            }
        }

        private double Weight
        {
            /*get
            {
                return weight;
            }*/
            set
            {
                if(value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                weight = value;
            }
        }


        public double CalculatingCalories()
        {
            double modifierDough = 0;
            double modifierTechnique = 0;

            if(flourType.ToLower() == "white")
            {
                modifierDough = 1.5;
            }
            else if(flourType.ToLower() == "wholegrain")
            {
                modifierDough = 1.0;
            }

            if(bakingTechnique.ToLower() == "crispy")
            {
                modifierTechnique = 0.9;
            }
            else if(bakingTechnique.ToLower() == "chewy")
            {
                modifierTechnique = 1.1;
            }
            else if(bakingTechnique.ToLower() == "homemade")
            {
                modifierTechnique = 1.0;
            }

            return (2 * weight) * modifierDough * modifierTechnique;
        }
    }
}
