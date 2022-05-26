using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero()
            {
                BatteryKWh = 15.6,
                MainColor = "Neon Green",
                MaximumOccupancy = 2

            };
            Tesla modelS = new Tesla()
            {
                BatteryKWh = 40.5,
                MainColor = "Silver",
                MaximumOccupancy = 5
            };
            Cessna mx410 = new Cessna()
            {
                FuelCapacity = 53,
                MainColor = "Yellow",
                MaximumOccupancy = 6
            };
            Ram crew = new Ram()
            {
                FuelCapacity = 26,
                MainColor = "Red",
                MaximumOccupancy = 3

            };

            fxs.Drive();
            fxs.Turn("right");
            fxs.Stop();

            Console.WriteLine();

            modelS.Drive();
            modelS.Turn("right");
            modelS.Stop();

            Console.WriteLine();

            mx410.Drive();
            mx410.Turn("left");
            mx410.Stop();

            Console.WriteLine();

            crew.Drive();
            crew.Turn("right");
            crew.Stop();
        }
    }
}
