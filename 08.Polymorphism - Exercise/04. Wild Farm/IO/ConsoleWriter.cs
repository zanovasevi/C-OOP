﻿using System;
using WildFarm.IO.Contracts;

namespace WildFarm.IO
{
    public class ConsoleWriter : IWritable
    {
        public void Write(string text)
        {
            Console.Write(text);
        }

        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}
