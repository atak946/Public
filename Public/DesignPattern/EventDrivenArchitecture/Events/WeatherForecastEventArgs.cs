using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventDrivenArchitecture.Events
{
    public class WeatherForecastEventArgs : EventArgs
    {
        public int Day { get; set; }

        public WeatherForecastEventArgs(int day)
        {
            Day = day;
        }
    }
}
