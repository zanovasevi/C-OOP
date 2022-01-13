using System;
using System.Collections.Generic;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            this.Bag = new List<Product>();
        }

        public string Name
        {
            get => name;
            private set
            {
                if (String.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                name = value;
            }
        }

        public decimal Money
        {
            get => money;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                money = value;
            }
        }

        public List<Product> Bag { get; set; }

        public bool BuyProduct(Product shopProduct)
        {
            if(Money >= shopProduct.Price)
            {
                money -= shopProduct.Price;
                Bag.Add(shopProduct);
                return true;
            }

            return false;
        }
    }
}
