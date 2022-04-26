﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Domain.Interfaces
{
    public interface IModel<T>
    {
        void Add(T t);
        bool Delete(int id);
        List<T> Read();
    }
}