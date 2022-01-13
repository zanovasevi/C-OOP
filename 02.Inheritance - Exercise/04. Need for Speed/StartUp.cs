using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle(100, 50);

            vehicle.Drive(2);
            Console.WriteLine(vehicle);
            
        }
    }
}
