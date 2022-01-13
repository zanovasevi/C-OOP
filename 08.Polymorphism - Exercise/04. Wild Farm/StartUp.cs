using System;
using WildFarm.Core;
using WildFarm.IO;
using WildFarm.IO.Contracts;

namespace WildFarm
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            IReadable reader = new ConsoleReader();
            IWritable writer = new ConsoleWriter();

            Engine engine = new Engine(reader, writer);
            engine.Run();
        }
    }
}
