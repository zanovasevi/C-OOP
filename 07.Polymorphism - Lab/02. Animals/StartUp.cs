using System;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Animal cat = new Cat("Pesho", "W");
            Animal dog = new Dog("Gosho", "Meet");

            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());
        }
    }
}
