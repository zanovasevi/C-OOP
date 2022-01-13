using System;
namespace WildFarm.IO.Contracts
{
    public interface IWritable
    {
        public void Write(string text);

        public void WriteLine(string text);
    }
}
