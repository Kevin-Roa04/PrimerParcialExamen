using Examen.Domain.Entities;
using Examen.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infraestructure.Repository
{
    public class BinaryObjetoRepository : IObjetoModel
    {
        private RAFContext Context;
        private const int Size = 0;

        public BinaryObjetoRepository()
        {
            this.Context = new RAFContext("", Size);
        }
        public void Add(Objeto t)
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

        public Objeto GetById(int id)
        {
            try
            {
                return Context.Get<Objeto>(id);
            }
            catch(Exception)
            {
                throw;
            }
        }

        public List<Objeto> Read()
        {
            try
            {
                return Context.GetAll<Objeto>();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public void Update(Objeto t)
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
    }
}
