using System;
using System.Collections.Generic;
using System.Linq;

namespace Animals
{
    public class Engine
    {
        private readonly List<Animal> animals;

        public Engine()
        {
            animals = new List<Animal>();
        }

        public void Run()
        {
            var firstCommand = Console.ReadLine();

            while (firstCommand != "Beast!")
            {
                string[] secondCommand = Console.ReadLine().Split(" ").ToArray();

                Animal animal;

                try
                {
                    animal = GetAnimal(firstCommand, secondCommand);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    firstCommand = Console.ReadLine();
                    continue;
                }

                
                animals.Add(animal);


                firstCommand = Console.ReadLine();
            }

            foreach(Animal animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

        private Animal GetAnimal(string firstCommand, string[] secondCommand)
        {
            string name = secondCommand[0];
            int age = int.Parse(secondCommand[1]);
            string gender = secondCommand[2];

            Animal animal = null;

            if (firstCommand == "Dog")
            {
                animal = new Dog(name, age, gender);
            }
            else if (firstCommand == "Cat")
            {
                animal = new Cat(name, age, gender);
            }
            else if (firstCommand == "Frog")
            {
                animal = new Frog(name, age, gender);
            }
            else if (firstCommand == "Kitten")
            {
                animal = new Kitten(name, age);
            }
            else if (firstCommand == "Tomcat")
            {
                animal = new Tomcat(name, age);
            }
            else
            {
                throw new ArgumentException("Invalid input!");
            }

            return animal;
        }
    }
}
