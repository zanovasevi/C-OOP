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

            string[] secondInput = Console.ReadLine().Split();
            double truckFuelQuantity = double.Parse(secondInput[1]);
            double truckFuelConsumption = double.Parse(secondInput[2]);

            Car car = new Car(carFuelQuantity, carFuelConsumption);
            Truck truck = new Truck(truckFuelQuantity, truckFuelConsumption);

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
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
        }
    }
}
