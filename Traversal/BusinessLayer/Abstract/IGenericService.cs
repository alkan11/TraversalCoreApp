﻿using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void TAdd(T entity);
        void TRemove(T entity);
        void TUpdate(T entity);
        List<T> TGetAll();
        T TGetById(int id);
        //List<T> GetByFilter(Expression<Func<T, bool>> filter);
    }
}
