using EventDrivenArchitecture.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventDrivenArchitecture.Services.Abstract
{
    public interface IWeatherForecastService
    {
        event EventHandler<WeatherForecastEventArgs> OnWeatherTransactionProcessed;
        IEnumerable<WeatherForecast> GetWeatherForecast(int days);
    }
}
