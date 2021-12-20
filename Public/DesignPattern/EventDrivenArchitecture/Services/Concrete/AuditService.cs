using EventDrivenArchitecture.Events;
using EventDrivenArchitecture.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventDrivenArchitecture.Services.Concrete
{
    public class AuditService : IAuditService
    {
        public void Subscribe(IWeatherForecastService weatherForecastService)
        {
            weatherForecastService.OnWeatherTransactionProcessed += WriteAuditLog;
        }

        private void WriteAuditLog(object sender, WeatherForecastEventArgs e)
        {
            Console.WriteLine($"AUDIT LOG: {e.Day} günlük hava durumu sorgulandı.");
        }
    }
}
