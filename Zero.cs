using System;

namespace Garage
{
    public class Zero : Vehicle, IElectric  // Electric motorcycle
    {
        public double BatteryKWh { get; set; }
        public int CurrentChargePercentage{ get; set;}

        public Zero()
        {
            BatteryKWh = 42.5;
            CurrentChargePercentage = 25;
        }

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero whips past. Zooooom!");
        }
         public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Zero screeches to a halt");
        }
    }
}