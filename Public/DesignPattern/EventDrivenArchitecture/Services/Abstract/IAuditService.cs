using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventDrivenArchitecture.Services.Abstract
{
    public interface IAuditService
    {
        void Subscribe(IWeatherForecastService weatherForecastService);
    }
}
