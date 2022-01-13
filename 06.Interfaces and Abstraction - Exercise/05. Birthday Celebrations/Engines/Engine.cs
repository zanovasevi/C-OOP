using System;
using System.Collections.Generic;
using BorderControl.Factories;
using BorderControl.IO.Contracts;

namespace BorderControl.Engines
{
    public class Engine
    {
        private IReader reader;
        private IWriter writer;
        private CitizenFactory citizenFactory;
        private RobotFactory robotFactory;
        private PetFactory petFactory;
        private ICollection<string> list;

        public Engine(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
            citizenFactory = new CitizenFactory();
            robotFactory = new RobotFactory();
            petFactory = new PetFactory();
            list = new List<string>();
        }

        public void Run()
        {
            string input = reader.ReadLine();

            while(input != "End")
            {
                string[] splitted = input.Split();

                string type = splitted[0];

                ICitizen citizen = null;
                IRobot robot = null;
                IPet pet = null;

                if(type == "Citizen")
                {
                    citizen = citizenFactory.GetCitizen(splitted);
                    list.Add(citizen.Birthdate);
                }
                else if(type == "Robot")
                {
                    robot = robotFactory.GetRobot(splitted);
                }
                else if(type == "Pet")
                {
                    pet = petFactory.GetPet(splitted);
                    list.Add(pet.Birthdate);
                }

                input = reader.ReadLine();
            }

            string year = reader.ReadLine();

            foreach(var item in list)
            {
                if(item.EndsWith(year))
                {
                    writer.WriteLine(item);
                }
            }
        }
    }
}
