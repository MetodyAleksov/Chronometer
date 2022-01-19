using System.Collections.Generic;
using System.Threading.Tasks;

namespace Chronometer
{
    public interface IChronometer
    {
        string GetTime { get; }

        List<string> Laps { get; }

        Task Start();

        Task Stop();

        string Lap();

        string ShowLaps();

        void Reset();
    }
}