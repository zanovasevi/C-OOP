using System;
using BorderControl.Engines;
using BorderControl.IO;
using BorderControl.IO.Contracts;

namespace BorderControl
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            Engine engine = new Engine(reader, writer);
            engine.Run();
        }
    }
}
