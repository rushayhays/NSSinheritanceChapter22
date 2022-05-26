using System;

namespace Garage
{
    public class Zero : Vehicle  // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
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