using System;

namespace Garage
{
    public class Tesla : Vehicle  // Electric car
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
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