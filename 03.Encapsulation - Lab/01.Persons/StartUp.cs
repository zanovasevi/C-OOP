using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main()
        {
            var lines = int.Parse(Console.ReadLine().Trim());
            var persons = new List<Person>();

            for(int i = 0; i < lines; i++)
            {
                var args = Console.ReadLine().Split(" ");
                var person = new Person(args[0], args[1], int.Parse(args[2]));
                persons.Add(person);
            }

            var orderedPersons = persons.OrderBy(p => p.FirstName)
                .ThenBy(p => p.Age)
                .ToList();

            foreach(var person in orderedPersons)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
