using System;
using Raiding2.IO;
using Raiding2.IO.Interfaces;

namespace Raiding2
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
