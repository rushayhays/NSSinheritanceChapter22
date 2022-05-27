using System;

namespace Garage
{
    public class Cessna : Vehicle, IGas // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage{ get; set; }

        public Cessna()
        {
            FuelCapacity = 40.0;
            CurrentTankPercentage = 30;
        }

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flies past. Mrrroooom!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Cessna makes a wide arc in the sky and turns {direction}");
        }
         public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Cessna rolls to a stop after rolling a mile down the runway.");
        }
    }
}