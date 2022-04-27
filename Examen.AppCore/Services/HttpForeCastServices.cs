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
    public class HttpForeCastServices : IHttpForeCastServices
    {
        IHttpForeCastClient Client;

        public HttpForeCastServices(IHttpForeCastClient httpForeCastClient)
        {
            this.Client = httpForeCastClient;
        }
        public Task<ForeCast> GetWeatherByCityNameAsync(string city)
        {
            return Client.GetWeatherByCityNameAsync(city);
        }
    }
}
