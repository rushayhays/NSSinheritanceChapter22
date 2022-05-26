using System;

namespace Garage
{
    public class Ram : Vehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram rumbles past. Brum,brum,brum,Brum!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Ram struggles with its garbage turn radius, but eventually turns {direction}");
        }
    }
}