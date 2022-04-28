using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Domain.Entities
{
    public class HistoricalWeather
    {
        public double lat { get; set; } // 8
        public double lon { get; set; } // 8
        public string timezone { get; set; } //50
        public int timezone_offset { get; set; } // 4
        public Current current { get; set; }
        public List<Hourly> hourly { get; set; }

        public class Weather
        {
            public string TimeZone { get; set; } //28
            public int id { get; set; } // 4
            public string main { get; set; }  // 18
            public string description { get; set; } // 28
            public string icon { get; set; } // 18
        }

        public class Current
        {
            public string name { get; set; }
            public int dt { get; set; } // 4
            public int sunrise { get; set; } // 4 
            public int sunset { get; set; }// 4
            public double temp { get; set; }// 8
            public double feels_like { get; set; }// 8
            public int pressure { get; set; }// 4
            public int humidity { get; set; }// 4
            public double dew_point { get; set; }// 4
            public double uvi { get; set; }// 4
            public int clouds { get; set; }// 4
            public int visibility { get; set; }// 4
            public double wind_speed { get; set; }// 4
            public int wind_deg { get; set; } // 4
            public double wind_gust { get; set; } // 4
            public List<Weather> weather { get; set; }
        }

        public class Snow
        {
            public double _1h { get; set; } //8
        }

        public class Hourly
        {
            public int dt { get; set; } //4
            public double temp { get; set; } //8
            public double feels_like { get; set; } //8
            public int pressure { get; set; } //4
            public int humidity { get; set; } //4
            public double dew_point { get; set; } //8
            public double uvi { get; set; } //8
            public int clouds { get; set; } //4
            public int visibility { get; set; } //4
            public double wind_speed { get; set; } //8
            public int wind_deg { get; set; } //4
            public double wind_gust { get; set; } //8
            public List<Weather> weather { get; set; }
            public Snow snow { get; set; } //8
        }

    }
}
