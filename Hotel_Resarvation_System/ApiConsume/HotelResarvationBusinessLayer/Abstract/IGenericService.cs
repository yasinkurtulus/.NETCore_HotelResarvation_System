﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelResarvationBusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void TInsert(T entity);
        void TDelete(T entity);
        void TUpdate(T entity);
        List<T> TGetAll();
        T TGetById(int id);
    }
}
