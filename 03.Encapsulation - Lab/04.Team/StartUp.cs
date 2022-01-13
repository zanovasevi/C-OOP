using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {
        public static void Main()
        {
            List<Person> persons = new List<Person>();

            var lines = int.Parse(Console.ReadLine());

            for(int i = 0; i < lines; i++)
            {
                var arg = Console.ReadLine().Split(" ").ToArray();

                var person = GetPerson(arg);
                persons.Add(person);
            }

            Team team = new Team("SoftUni");

            foreach(Person person in persons)
            {
                team.AddPlayer(person);
            }

            Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
            Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");
        }

        private static Person GetPerson(string[] arg)
        {
            string firstName = arg[0];
            string lastName = arg[1];
            int age = int.Parse(arg[2]);
            decimal salary = decimal.Parse(arg[3]);

            Person person = new Person(firstName, lastName, age, salary);
            return person;
        }
    }
}
