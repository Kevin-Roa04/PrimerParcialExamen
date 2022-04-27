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
    public class ForeCastServices : BaseServices<ForeCast>, IForeCastServices
    {

        IForeCastModel Model;
        public ForeCastServices(IForeCastModel model) : base(model)
        {
            this.Model = model;
        }

        public ForeCast GetById(int id)
        {
            return Model.GetById(id);
        }

        public void Update(ForeCast t)
        {
            Model.Update(t);
        }
    }
}
