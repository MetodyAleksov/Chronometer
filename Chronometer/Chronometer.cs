using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace Chronometer
{
    public class Chronometer : IChronometer
    {
        private Stopwatch stopwatch;

        public Chronometer()
        {
            stopwatch = new Stopwatch();
            Laps = new List<string>();
        }

        public string GetTime => stopwatch.Elapsed.ToString(@"g");
        public List<string> Laps { get; private set; }

        public async Task Start()
        {
            stopwatch.Start();
        }

        public async Task Stop()
        {
            stopwatch.Stop();
        }

        public string Lap()
        {
            string lap = GetTime;
            Laps.Add(lap);
            return lap;
        }

        public string ShowLaps()
        {
            StringBuilder sb = new StringBuilder();

            if (Laps.Count == 0)
            {
                return "Laps: none";
            }

            sb.AppendLine("Laps: ");

            foreach (var lap in Laps)
            {
                sb.AppendLine(lap);
            }

            return sb.ToString().TrimEnd();
        }

        public void Reset()
        {
            stopwatch.Reset();
        }
    }
}