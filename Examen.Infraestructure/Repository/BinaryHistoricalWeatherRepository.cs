using Examen.Domain.Entities;
using Examen.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infraestructure.Repository
{
    public class BinaryHistoricalWeatherRepository : IHistoricalWeatherModel
    {
        private RAFContext Context;
        private const int Size = 130;

        public BinaryHistoricalWeatherRepository()
        {
            this.Context = new RAFContext("HistoricalWeather", Size);
        }
        public void Add(HistoricalWeather t)
        {
            try
            {
                Context.Create(t);
            }
            catch(Exception)
            {
                throw;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                return Context.Delete(id);
            }
            catch(Exception)
            {
                throw;
            }
        }

        public HistoricalWeather GetById(int id)
        {
            try
            {
                return Context.Get<HistoricalWeather>(id);
            }
            catch(Exception)
            {
                throw;
            }
        }

        public List<HistoricalWeather> Read()
        {
            try
            {
                return Context.GetAll<HistoricalWeather>();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public void Update(HistoricalWeather t)
        {
            try
            {
                Context.Update(t);
            }
            catch
            {
                throw;
            }
        }
        public List<string> GetNameCitys()
        {
            List<string> names = new List<string>();
            List<HistoricalWeather> historicalWeathers = Read();
            if (historicalWeathers.Count >= 1)
            {
                foreach (HistoricalWeather historical in historicalWeathers)
                {
                    if (historical is null)
                    {
                        continue;
                    }
                    names.Add(historical.Name);
                }
                return names;
            }
            return null;
        }
    }
}
