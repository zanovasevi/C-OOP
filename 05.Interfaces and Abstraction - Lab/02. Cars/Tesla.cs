using System;
using Cars.Contracts;

namespace Cars
{
    public class Tesla : Car, ICar, IElectricCar
    {

        public Tesla(string model, string color, int battery) : base(model, color)
        {
            this.Battery = battery;
        }


        public int Battery { get; set; }

        protected override string GetCarInfo()
        {
            return base.GetCarInfo() + $" with {this.Battery} Batteries";
        }
    }
}
