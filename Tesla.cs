using System;

namespace Garage
{
    public class Tesla : Vehicle, IElectric  // Electric car
    {
        public double BatteryKWh { get; set; }
       public int CurrentChargePercentage{ get; set;}

        public Tesla()
        {
            BatteryKWh = 75.0;
            CurrentChargePercentage = 42;
        }

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla glides past. hmmmmmmmmmm");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Tesla deftly turns {direction}");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Tesla deccelerates and stops");
        }
        
    }
}