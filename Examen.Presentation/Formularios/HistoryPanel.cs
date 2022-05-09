using Examen.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen.Presentation.Formularios
{
    public partial class HistoryPanel : UserControl
    {
        public HistoryPanel(List<HistoricalWeather.Weather> weather, HistoricalWeather historicalWeather)
        {
            InitializeComponent();
            lblCity.Text = historicalWeather.Name;
            lblTemp.Text = historicalWeather.TempOpen.ToString();
            lblWeather.Text = historicalWeather.WeatherOpen;
            foreach (HistoricalWeather.Weather weather1 in weather)
            {
                flpDetails.Controls.Add(new DetailsHistory("Clima", weather1.description, weather1.Temp.ToString()));
            }
        }
    }
}
