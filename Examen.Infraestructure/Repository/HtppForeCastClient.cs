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
    public class HtppForeCastClient : IHttpForeCastClient
    {
        async Task<ForeCast> IHttpForeCastClient.GetWeatherByCityNameAsync(string city)
        {
            string url = $"{AppSettings.ApiUrl}{city}&appid={AppSettings.Token}";
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

                return Newtonsoft.Json.JsonConvert.DeserializeObject<ForeCast>(jsonObject);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
