using Examen.Common;
using Examen.Domain.Entities;
using Examen.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infraestructure.Repository
{
    public class HttpOpenWeatherClient : IHttpOpenWeatherClient
    {
        public async Task<OpenWeather> GetWeatherByCityNameAsync(string city)
        {

            string url = $"{AppSettings.ApiOpenWeatherUrl}{city}&units={AppSettings.units}&lang=sp&appid={AppSettings.Token}";
            string jsonObject = string.Empty;
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    jsonObject = await httpClient.GetAsync(url).Result.Content.ReadAsStringAsync();
                }

                if (string.IsNullOrEmpty(jsonObject))
                {
                    throw new NullReferenceException("El objeto json no puede ser null.");
                }

                return Newtonsoft.Json.JsonConvert.DeserializeObject<OpenWeather>(jsonObject);
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
