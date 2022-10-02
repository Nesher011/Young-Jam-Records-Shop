﻿using System.Linq.Expressions;

namespace YoungJamRecordsShop.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        //T - Album Type
        T GetFirstOrDefault(Expression<Func<T, bool>> filter);

        IEnumerable<T> GetAll();

        void Add(T entity);

        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entities);
    }
}