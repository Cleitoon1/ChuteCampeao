using ChuteCampeao.Domain.Interfaces.Repositories;
using ChuteCampeao.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace ChuteCampeao.Infra.Data.Repositories
{
    public class BaseRep<T> : IDisposable, IBaseRep<T> where T : class
    {
        protected ChuteCampeaoContext Db = new ChuteCampeaoContext();

        public void Insert(T obj)
        {
            Db.Set<T>().Add(obj);
            Db.SaveChanges();
        }

        public T Get(int id)
        {
            return Db.Set<T>().Find(id);

        }

        public IEnumerable<T> GetAll()
        {
            return Db.Set<T>().ToList();
        }

        public IEnumerable<T> GetPaginated(IQueryable<T> query, string sortField, bool isDescending, int initialPage, int pageSize)
        {
            var pi = typeof(T).GetProperty(sortField);
            var newQuery = query.Skip(initialPage * pageSize);
            newQuery = isDescending == true ? newQuery.OrderByDescending(x => pi.GetValue(x, null)) : newQuery.OrderBy(x => pi.GetValue(x, null));
            return newQuery;
        }

        public void Update(T obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public void Remove(T obj)
        {
            Db.Set<T>().Remove(obj);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
