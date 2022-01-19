using System;
using System.Threading.Tasks;

namespace Chronometer
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string input = Console.ReadLine();

            Chronometer chronometer = new Chronometer();

            while (input != "stop")
            {
                if (input == "start")
                {
                    await chronometer.Start();
                }
                else if (input == "reset")
                {
                    chronometer.Reset();
                }
                else if (input == "lap")
                {
                    chronometer.Lap();
                }
                else if (input == "elapsed")
                {
                    Console.WriteLine(chronometer.GetTime);
                }
                else if (input == "showlaps")
                {
                    Console.WriteLine(chronometer.ShowLaps());
                }

                input = Console.ReadLine();
            }

            await chronometer.Stop();
        }
    }
}
