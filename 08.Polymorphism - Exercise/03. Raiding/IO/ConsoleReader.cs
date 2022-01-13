using System;
using Raiding2.IO.Interfaces;

namespace Raiding2.IO
{
    public class ConsoleReader : IReadable
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
