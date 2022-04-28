using Examen.AppCore.IServices;
using Examen.Domain.Entities;
using Examen.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.AppCore.Services
{
    public class HttpHistoricalWeatherServices : IHttpHistoricalWeatherServices
    {
        IHttpHistoricalWeatherClient Client;

        public HttpHistoricalWeatherServices(IHttpHistoricalWeatherClient httpForeCastClient)
        {
            this.Client = httpForeCastClient;
        }
        public Task<HistoricalWeather> GetWeatherByLanAndLonAsync(string lat, string lon, long time)
        {
            return Client.GetWeatherByLanAndLonAsync(lat, lon, time);
        }
    }
}
