using System;
using System.Collections.Generic;

namespace Pizza_Calories
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                string[] inputNamePizza = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                string pizzaName = inputNamePizza[1];
                Pizza pizza = new Pizza(pizzaName);
                
                string inputDough = Console.ReadLine();
                string[] splitted = inputDough.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                string flourType = splitted[1];
                string bakingTech = splitted[2];
                double grams = double.Parse(splitted[3]);
                Dough dough = new Dough(flourType, bakingTech, grams);

                pizza.Dough = dough;
                //Pizza pizza = new Pizza(pizzaName, dough);

                Topping topping = null;
                string inputTopping = Console.ReadLine();
                while (inputTopping != "END")
                {

                    string[] secondSplitted = inputTopping.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                    string toppingType = secondSplitted[1];
                    double toppingGrams = double.Parse(secondSplitted[2]);
                    topping = new Topping(toppingType, toppingGrams);
                    pizza.AddTopping(topping);

                    inputTopping = Console.ReadLine();
                }

                Console.WriteLine($"{pizzaName} - {pizza.CalculateTotalCalories():F2} Calories.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
