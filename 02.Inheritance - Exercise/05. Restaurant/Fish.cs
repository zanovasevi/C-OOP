﻿using System;
namespace Restaurant
{
    public class Fish : MainDish
    {
        private const double gramms = 22;

        public Fish(string name, decimal price)
            : base(name, price, gramms)
        {
        }
    }
}
