using Examen.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Domain.Interfaces
{
    public interface IHttpHistoricalWeatherClient
    {
        Task<HistoricalWeather> GetWeatherByLanAndLonAsync(string lat, string lon, long time);
    }
}
