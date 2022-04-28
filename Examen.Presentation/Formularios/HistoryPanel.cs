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
        public HistoryPanel(List<HistoricalWeather.Weather> weather, OpenWeather openWeather)
        {
            InitializeComponent();
            lblCity.Text = openWeather.Name;
            lblTemp.Text = openWeather.Main.Temp.ToString();
            lblWeather.Text = openWeather.Weather[0].Main;
            foreach (HistoricalWeather.Weather weather1 in weather)
            {
                flpDetails.Controls.Add(new DetailsHistory("Clima", weather1.main));
            }
        }
    }
}
