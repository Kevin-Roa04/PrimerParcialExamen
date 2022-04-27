using Examen.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.AppCore.IServices
{
    public interface IForeCastServices : IServices<ForeCast>
    {
        ForeCast GetById(int id);
        void Update(ForeCast t);
    }
}
