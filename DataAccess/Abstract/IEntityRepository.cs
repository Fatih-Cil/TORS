﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null); //filtre önemli değil
        T Get(Expression<Func<T, bool>> filter); //filtre önemli
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
