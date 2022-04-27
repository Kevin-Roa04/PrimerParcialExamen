using Examen.Domain.Entities;
using Examen.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infraestructure.Repository
{
    public class BinaryForeCastRepository : IForeCastModel
    {
        private RAFContext Context;
        private const int Size = 0;

        public BinaryForeCastRepository()
        {
            this.Context = new RAFContext("", Size);
        }
        public void Add(ForeCast t)
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

        public ForeCast GetById(int id)
        {
            try
            {
                return Context.Get<ForeCast>(id);
            }
            catch(Exception)
            {
                throw;
            }
        }

        public List<ForeCast> Read()
        {
            try
            {
                return Context.GetAll<ForeCast>();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public void Update(ForeCast t)
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
