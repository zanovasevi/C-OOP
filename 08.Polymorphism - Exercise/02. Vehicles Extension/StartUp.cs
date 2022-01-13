using System;

namespace Vehicles
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split();
            double carFuelQuantity = double.Parse(firstInput[1]);
            double carFuelConsumption = double.Parse(firstInput[2]);
            double carTankCapacity = double.Parse(firstInput[3]);

            string[] secondInput = Console.ReadLine().Split();
            double truckFuelQuantity = double.Parse(secondInput[1]);
            double truckFuelConsumption = double.Parse(secondInput[2]);
            double truckTankCapacity = double.Parse(secondInput[3]);

            string[] thirdInput = Console.ReadLine().Split();
            double busFuelQuantity = double.Parse(thirdInput[1]);
            double busFuelConsumption = double.Parse(thirdInput[2]);
            double busTankCapacity = double.Parse(thirdInput[3]);

            Car car = new Car(carFuelQuantity, carFuelConsumption, carTankCapacity);
            Truck truck = new Truck(truckFuelQuantity, truckFuelConsumption, truckTankCapacity);
            Bus bus = new Bus(busFuelQuantity, busFuelConsumption, busTankCapacity);

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] splitted = input.Split();
                string command = splitted[0];
                string vehicle = splitted[1];
                


                if(command == "Drive")
                {
                    double distance = double.Parse(splitted[2]);
                    if (vehicle == "Car")
                    {
                        Console.WriteLine(car.Drive(distance)); 
                    }
                    else if(vehicle == "Truck")
                    {
                        Console.WriteLine(truck.Drive(distance)); 
                    }
                    else if(vehicle == "Bus")
                    {
                        Console.WriteLine(bus.Drive(distance));
                    }
                }
                else if(command == "Refuel")
                {
                    double liters = double.Parse(splitted[2]);
                    if (vehicle == "Car")
                    {
                        car.Refuel(liters); 
                    }
                    else if (vehicle == "Truck")
                    {
                        truck.Refuel(liters); 
                    }
                    else if(vehicle == "Bus")
                    {
                        bus.Refuel(liters);
                    }
                }
                else if(command == "DriveEmpty")
                {
                    double distance = double.Parse(splitted[2]);
                    Console.WriteLine(bus.DriveEmpty(distance)); 
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:F2}");
        }
    }
}
