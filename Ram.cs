using System;

namespace Garage
{
    public class Ram : Vehicle, IGas // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public int CurrentTankPercentage{ get; set; }

        public Ram()
        {
            FuelCapacity = 26.0;
            CurrentTankPercentage = 10;
        }

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
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