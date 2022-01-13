using System;
using System.Collections.Generic;
using System.Linq;
using BorderControl.Factories;
using BorderControl.IO.Contracts;

namespace BorderControl.Engines
{
    public class Engine
    {
        private IReader reader;
        private IWriter writer;
        private CitizenFactory citizenFactory;
        private RebelFactory rebelFactory;
        private List<IBuyer> buyers;
        

        public Engine(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
            citizenFactory = new CitizenFactory();
            rebelFactory = new RebelFactory();
            buyers = new List<IBuyer>();
        }

        public void Run()
        {
            int n = int.Parse(reader.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Citizen citizen = null;
                Rebel rebel = null;

                string[] input = reader.ReadLine().Split();
                string name = input[0];

                if(input.Length == 4)
                {
                    citizen = citizenFactory.GetCitizen(input);
                    buyers.Add(citizen);
                }
                else if(input.Length == 3)
                {
                    rebel = rebelFactory.GetRebel(input);
                    buyers.Add(rebel);
                }
            }

            string inputName = reader.ReadLine();
            while(inputName != "End")
            {
                foreach(var person in buyers)
                {
                    if(person.Name == inputName)
                    {
                        person.BuyFood();
                    }
                }

                inputName = reader.ReadLine();
            }

            int totalFood = buyers.Sum(x => x.Food);
            writer.WriteLine(totalFood.ToString());
        }
    }
}
