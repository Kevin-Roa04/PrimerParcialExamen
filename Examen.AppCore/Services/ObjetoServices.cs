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
    public class ObjetoServices : BaseServices<Objeto>, IObjetoServices
    {

        IObjetoModel Model;
        public ObjetoServices(IObjetoModel model) : base(model)
        {
            this.Model = model;
        }

        public Objeto GetById(int id)
        {
            return Model.GetById(id);
        }

        public void Update(Objeto t)
        {
            Model.Update(t);
        }
    }
}
