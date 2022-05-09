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
    public class HistoricalWeatherServices : BaseServices<HistoricalWeather>, IHistorticalWeatherServices
    {

        IHistoricalWeatherModel Model;
        public HistoricalWeatherServices(IHistoricalWeatherModel model) : base(model)
        {
            this.Model = model;
        }

        public HistoricalWeather GetById(int id)
        {
            return Model.GetById(id);
        }

        public List<string> GetNameCitys()
        {
            return Model.GetNameCitys();
        }

        public void Update(HistoricalWeather t)
        {
            Model.Update(t);
        }
    }
}
