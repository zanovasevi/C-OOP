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
        private ICollection<string> list;

        public Engine(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
            citizenFactory = new CitizenFactory();
            robotFactory = new RobotFactory();
            list = new List<string>();
        }

        public void Run()
        {
            string input = reader.ReadLine();

            while(input != "End")
            {
                string[] splitted = input.Split();

                ICitizen citizen = null;
                IRobot robot = null;
                if(splitted.Length == 3)
                {
                    citizen = citizenFactory.GetCitizen(splitted);
                    list.Add(citizen.Id);
                }
                else
                {
                    robot = robotFactory.GetRobot(splitted);
                    list.Add(robot.Id);
                }

                input = reader.ReadLine();
            }

            string fakeId = reader.ReadLine();

            foreach(var item in list)
            {
                if(item.EndsWith(fakeId))
                {
                    writer.WriteLine(item);
                }
            }
        }
    }
}
