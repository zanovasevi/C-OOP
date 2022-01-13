using System;
namespace Restaurant
{
    public class Cake : Dessert
    {
        private const decimal cakePrice = 5;
        private const double gramms = 250;
        private const double caloriess = 1000;

        public Cake(string name)
            : base(name, cakePrice, gramms, caloriess)
        {
        }
    }
}
