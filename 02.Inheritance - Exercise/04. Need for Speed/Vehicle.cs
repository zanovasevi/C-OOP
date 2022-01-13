namespace NeedForSpeed
{
    public class Vehicle
    {
        private double defaultFuelConsumption  = 1.25;


        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
        }



        public virtual double FuelConsumption { get => defaultFuelConsumption; }

        public int HorsePower { get; set; }

        public double Fuel { get; set; }



        public virtual void Drive(double kilometers)
        {
            Fuel -= kilometers * FuelConsumption;
        }

        public override string ToString()
        {
            return $"{Fuel}";
        }
    }
}
