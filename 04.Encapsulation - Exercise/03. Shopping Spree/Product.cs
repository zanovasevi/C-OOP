using System;
namespace ShoppingSpree
{
    public class Product
    {
        private string name;
        private decimal price;

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string Name
        {
            get => name;
            private set
            {
                if(String.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                name = value;
            }
        }

        public decimal Price
        {
            get => price;
            private set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Price can't be a negative number");
                }

                price = value;
            }
        }
    }
}
