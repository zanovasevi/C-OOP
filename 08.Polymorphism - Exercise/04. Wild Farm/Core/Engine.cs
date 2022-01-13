using System;
using System.Collections.Generic;
using WildFarm.Factories;
using WildFarm.IO.Contracts;
using WildFarm.Models.Animals;
using WildFarm.Models.Foods;

namespace WildFarm.Core
{
    public class Engine
    {
        private IReadable reader;
        private IWritable writer;
        private AnimalFactory animalFactory;
        private FoodFactory foodFactory;
        private ICollection<Animal> animals;

        public Engine(IReadable reader, IWritable writer)
        {
            this.reader = reader;
            this.writer = writer;
            animalFactory = new AnimalFactory();
            foodFactory = new FoodFactory();
            animals = new List<Animal>();
        }

        public void Run()
        {
            string input = reader.ReadLine();

            while (input != "End")
            {
                string[] firstSplit = input.Split();
                Animal animal = animalFactory.CreateAnimal(firstSplit);
                animals.Add(animal);

                string[] secondSplit = reader.ReadLine().Split();
                Food food = foodFactory.CreateFood(secondSplit);

                writer.WriteLine(animal.ProduceSound());
                try
                {
                    animal.Feed(food);
                }
                catch(Exception ae)
                {
                    writer.WriteLine(ae.Message);                    
                }

                input = reader.ReadLine();
            }

            foreach (var anim in animals)
            {
                writer.WriteLine(anim.ToString());
            }
        }
    }
}
