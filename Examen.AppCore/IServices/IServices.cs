using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.AppCore.IServices
{
    public interface IServices<T>
    {

        void Add(T t);
        bool Delete(int id);
        List<T> Read();
    }
}
