using System;
using System.Text;

namespace Animals
{
    public abstract class Animal
    {
        private const string errorMessage = "Invalid input!";

        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public string Name
        {
            get => name;
            private set
            {
                if(String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(errorMessage);
                }

                name = value;
            }
        }

        public int Age
        {
            get => age;
            private set
            {
                if(value < 0)
                {
                    throw new ArgumentException(errorMessage);
                }

                age = value;
            }
        }

        public string Gender
        {
            get => gender;
            private set
            {
                if(value != "Male" && value != "Female")
                {
                    throw new ArgumentException(errorMessage);
                }

                gender = value;
            }
        }


        public abstract string ProduceSound();

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb
                .AppendLine($"{GetType().Name}")
                .AppendLine($"{Name} {Age} {Gender}")
                .AppendLine($"{ProduceSound()}");

            return sb.ToString().TrimEnd();
        }
    }
}
