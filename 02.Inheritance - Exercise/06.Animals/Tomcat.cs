﻿using System;
namespace Animals
{
    public class Tomcat : Cat
    {
        private const string defaultGender = "Male";

        public Tomcat(string name, int age)
            : base(name, age, defaultGender)
        {
        }


        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}
