using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Common
{
    public class AppSettings
    {
        public static string Token { get => ConfigurationManager.AppSettings.Get("Token"); }
        public static string ApiHistoricalWeatherUrl { get => ConfigurationManager.AppSettings.Get("ApiHistoricalWeatherUrl"); }
        public static string ApiOpenWeatherUrl { get => ConfigurationManager.AppSettings.Get("ApiOpenWeatherUrl"); }
        public static string units { get => ConfigurationManager.AppSettings.Get("Units"); }
    }
}
