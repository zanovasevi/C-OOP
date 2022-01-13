namespace NeedForSpeed
{
    public class Car : Vehicle
    {
        private double defaultFuelConsumption = 3.00;

        public Car(int horsePower, double fuel)
            :base(horsePower, fuel)
        {
        }


        public override double FuelConsumption
        {
            get => this.defaultFuelConsumption;
        }
    }
}
