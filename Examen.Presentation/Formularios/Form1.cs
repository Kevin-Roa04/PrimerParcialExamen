using Examen.AppCore.IServices;
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
    public partial class Form1 : Form
    {
        public IHistorticalWeatherServices historticalWeather;
        public IHttpHistoricalWeatherServices httpHistoricalWeather;
        public IHttpOpenWeatherServices httpOpenWeather;
        public OpenWeather openWeather;
        public HistoricalWeather historicalWeatherObj;
        List<HistoricalWeather.Weather> weather = new List<HistoricalWeather.Weather>();
        public Form1(IHistorticalWeatherServices historticalWeather, IHttpHistoricalWeatherServices httpHistoricalWeather, IHttpOpenWeatherServices httpOpenWeatherServices)
        {
            this.historticalWeather = historticalWeather;
            this.httpHistoricalWeather = httpHistoricalWeather;
            this.httpOpenWeather = httpOpenWeatherServices;
            InitializeComponent();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                flpContent.Controls.Clear();
                Task.Run(RequestOpenWeather).Wait();
                if (openWeather.Name == null)
                {
                    MessageBox.Show("No encontramos información de la ciudad", "Error en la busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Task.Run(RequestHistoricalWeather).Wait();
                if(historicalWeatherObj == null)
                {
                    MessageBox.Show("No encontramos información de la ciudad", "Error en la busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                flpContent.Controls.Add(new HistoryPanel(weather, openWeather));
                weather.Clear();
                LlenartxtInfo(0);
                flpCitys.Controls.Add(new DetailsHistory("Ciudad", historicalWeatherObj.current.name));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public async Task RequestOpenWeather()
        {
            openWeather = await httpOpenWeather.GetWeatherByCityNameAsync(txtCiudad.Text);
        }

        public async Task RequestHistoricalWeather()
        {
            for (int i = 0; i < 4; i++)
            {
                DateTime time = DateTime.Now.AddDays(-i - 1);

                long unix = ((DateTimeOffset)time).ToUnixTimeSeconds();

                historicalWeatherObj = await httpHistoricalWeather.GetWeatherByLanAndLonAsync(openWeather.Coord.Lat.ToString(), openWeather.Coord.Lon.ToString(), unix);
                HistoricalWeather.Weather weathers = historicalWeatherObj.hourly[6].weather[0];
                weathers.TimeZone = historicalWeatherObj.timezone;
                weather.Add(weathers);
            }
            historicalWeatherObj.current.name = openWeather.Name;
            historticalWeather.Add(historicalWeatherObj);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LlenartxtInfo(1);
            List<string> names = GetNameCitys();
            if (names is null)
                return;
            else
            {
                foreach(string name in names)
                {
                    DetailsHistory detailsHistory = new DetailsHistory("Ciudad", name);
                    flpCitys.Controls.Add(detailsHistory);
                }
            }
        }
        private List<string> GetNameCitys()
        {
            List<string> names = new List<string>();
            List<HistoricalWeather> historicalWeathers = historticalWeather.Read();
            if (historicalWeathers.Count >= 1)
            {
                foreach (HistoricalWeather historical in historicalWeathers)
                {
                    if (historical is null)
                    {
                        continue;
                    }
                    names.Add(historical.current.name);
                }
                return names;
            }
            return null;
        }

        private void LlenartxtInfo(int i)
        {
            if (i == 0)
            {
                if (string.IsNullOrEmpty(txtInfo.Text))
                {
                    txtInfo.Text = txtCiudad.Text + " ";
                }
                else
                {
                    txtInfo.Text = txtCiudad.Text + ", " + txtInfo.Text;
                }
            }
            else
            {
                List<String> names = GetNameCitys();
                if(names is null)
                {
                    return;
                }
                foreach(string name in names)
                {
                    if (string.IsNullOrEmpty(txtInfo.Text))
                    {
                        txtInfo.Text = name + " ";
                    }
                    else
                    {
                        txtInfo.Text = name + ", " + txtInfo.Text;
                    }
                }
            }
        }
    }
}
