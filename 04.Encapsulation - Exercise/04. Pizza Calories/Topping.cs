using System;
namespace Pizza_Calories
{
    public class Topping
    {
        private string type;
        private double weight;


        public Topping(string type, double weight)
        {
            Type = type;
            Weight = weight;
        }


        private string Type
        {
            /*get
            {
                return type;
            }*/
            set
            {
                if (value.ToLower() != "meat" && value.ToLower() != "veggies"
                    && value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                type = value;
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
                if(value < 1 || value > 50)
                {
                    throw new ArgumentException($"{type} weight should be in the range [1..50].");
                }
                weight = value;
            }
        }

        public double CalculatingTopping()
        {
            double modifier = 0;
            if(type.ToLower() == "meat")
            {
                modifier = 1.2;
            }
            else if(type.ToLower() == "veggies")
            {
                modifier = 0.8;
            }
            else if(type.ToLower() == "cheese")
            {
                modifier = 1.1;
            }
            else if(type.ToLower() == "sauce")
            {
                modifier = 0.9;
            }

            return 2 * weight * modifier;
        }
    }
}
