using ChuteCampeao.Domain.Interfaces;
using ChuteCampeao.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ChuteCampeao.Infra.Data.Repositories
{
    public class RepBase<T> : IDisposable, IRepBase<T> where T : class
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
            throw new NotImplementedException();
        }
    }
}
