﻿using System;
namespace Animals
{
    public class Kitten : Cat
    {
        private const string defaultGender = "Female";

        public Kitten(string name, int age)
            : base(name, age, defaultGender)
        {
        }


        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
