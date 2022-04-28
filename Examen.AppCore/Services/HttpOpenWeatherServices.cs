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
    public class HttpOpenWeatherServices : IHttpOpenWeatherServices
    {
        IHttpOpenWeatherClient httpOpenWeather; 
        public HttpOpenWeatherServices(IHttpOpenWeatherClient httpOpenWeather)
        {
            this.httpOpenWeather = httpOpenWeather;
        }
        public Task<OpenWeather> GetWeatherByCityNameAsync(string city)
        {
            return httpOpenWeather.GetWeatherByCityNameAsync(city);
        }
    }
}
