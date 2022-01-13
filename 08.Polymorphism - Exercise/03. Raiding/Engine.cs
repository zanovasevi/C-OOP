using System;
using System.Collections.Generic;
using Raiding2.Factories;
using Raiding2.IO;
using Raiding2.IO.Interfaces;

namespace Raiding2
{
    public class Engine
    {
        private IReadable reader;
        private IWritable writer;
        List<BaseHero> heroes;
        Factory factory;

        public Engine(IReadable reader, IWritable writer)
        {
            this.reader = reader;
            this.writer = writer;
            heroes = new List<BaseHero>();
            factory = new Factory();
        }

        public void Run()
        {
            int n = int.Parse(reader.ReadLine());
            BaseHero hero = null;

            while(heroes.Count != n)
            {
                string name = reader.ReadLine();
                string type = reader.ReadLine();

                hero = factory.GetHero(name, type);

                if(hero == null)
                {
                    writer.WriteLine("Invalid hero!");
                }
                else
                {
                    heroes.Add(hero);
                }
            }

            int bossPower = int.Parse(reader.ReadLine());
            int totalSum = 0;

            foreach(var person in heroes)
            {
                writer.WriteLine(person.CastAbility());
                totalSum += person.Power;
            }

            if(totalSum >= bossPower)
            {
                writer.WriteLine("Victory!");
            }
            else
            {
                writer.WriteLine("Defeat...");
            }
        }
    }
}
