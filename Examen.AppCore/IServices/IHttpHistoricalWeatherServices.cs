using Examen.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.AppCore.IServices
{
    public interface IHttpHistoricalWeatherServices
    {
        Task<HistoricalWeather> GetWeatherByLanAndLonAsync(string lat, string lon, long time);
    }
}
