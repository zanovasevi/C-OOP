using System;
using BorderControl.IO.Contracts;

namespace BorderControl.IO
{
    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
