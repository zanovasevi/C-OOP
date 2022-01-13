using System;
using System.Collections.Generic;
using System.Linq;
namespace Pizza_Calories
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name)
        {
            Name = name;
            dough = new Dough();
            toppings = new List<Topping>();
        }
        
        public Pizza(string name, Dough dough) : this(name)
        {
            Dough = dough;
            toppings = new List<Topping>();
        }


        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                name = value;
            }
        }

        public Dough Dough
        {
            get
            {
                return dough;
            }
            set
            {
                dough = value;
            }
        }

        public void AddTopping(Topping topping)
        {
            toppings.Add(topping);
            if(toppings.Count > 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
        }

        public double CalculateTotalCalories()
        {
            return dough.CalculatingCalories() + toppings.Sum(t => t.CalculatingTopping());
        }
    }
}
