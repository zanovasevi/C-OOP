using System;
using WildFarm.Animals.Birds;
using WildFarm.Animals.Mammals;
using WildFarm.Animals.Mammals.Felines;
using WildFarm.Models.Animals;

namespace WildFarm.Factories
{
    public class AnimalFactory
    {
        public Animal CreateAnimal(string[] firstSplit)
        {
            Animal animal = null;

            string type = firstSplit[0];
            string name = firstSplit[1];
            double weight = double.Parse(firstSplit[2]);

            if (type == "Cat" || type == "Tiger")
            {
                string livingRegion = firstSplit[3];
                string breed = firstSplit[4];

                if(type == "Cat")
                {
                    animal = new Cat(name, weight, livingRegion, breed);
                }
                else
                {
                    animal = new Tiger(name, weight, livingRegion, breed);
                }
            }
            else if (type == "Hen" || type == "Owl")
            {
                double wingSize = double.Parse(firstSplit[3]);

                if (type == "Hen")
                {
                    animal = new Hen(name, weight, wingSize);
                }
                else
                {
                    animal = new Owl(name, weight, wingSize);
                }
            }
            else if (type == "Mouse" || type == "Dog")
            {
                string livingRegion = firstSplit[3];

                if (type == "Mouse")
                {
                    animal = new Mouse(name, weight, livingRegion);
                }
                else
                {
                    animal = new Dog(name, weight, livingRegion);
                }
            }

            return animal;
        }
    }
}
