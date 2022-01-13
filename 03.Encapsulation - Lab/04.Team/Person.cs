using System;
namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        private const string invalidFirstName = "First name cannot contain fewer than 3 symbols!";
        private const string invalidLastName = "Last name cannot contain fewer than 3 symbols!";
        private const string invalidAge = "Age cannot be zero or a negative integer!";
        private const string invalidSalary = "Salary cannot be less than 650 leva!";

        private const int numSymbols = 3;

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        public string FirstName {
            get => firstName;
            private set
            {
                if(value.Length < numSymbols)
                {
                    throw new ArgumentException(invalidFirstName);
                }

                firstName = value;
            }
        }

        public string LastName {
            get => lastName;
            private set
            {
                if(value.Length < numSymbols)
                {
                    throw new ArgumentException(invalidLastName);
                }

                lastName = value;
            }
        }

        public int Age {
            get => age;
            private set
            {
                if(value <= 0)
                {
                    throw new ArgumentException(invalidAge);
                }

                age = value;
            }
        }

        public decimal Salary
        {
            get => salary;
            private set
            {
                if(value < 460)
                {
                    throw new ArgumentException(invalidSalary);
                }

                salary = value;
            }
        }


        public override string ToString()
        {
            return $"{FirstName} {LastName} receives {Salary:F2} leva.";
        }

        public void IncreaseSalary(decimal percentage)
        {
            if(Age > 30)
            {
                Salary += Salary * percentage / 100;
            }
            else
            {
                Salary += Salary * percentage / 200;
            }
        }
    }
}
