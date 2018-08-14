using ChuteCampeao.Domain.Interfaces.Repositories;
using ChuteCampeao.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuteCampeao.Services.Services
{
    public class BaseService<T> : IDisposable, IBaseService<T> where T : class
    {
        private readonly IBaseRep<T> _rep;

        public BaseService(IBaseRep<T> rep)
        {
            this._rep = rep;
        }

        public void Add(T obj)
        {
            _rep.Insert(obj);
        }

        public IEnumerable<T> GetAll()
        {
            return _rep.GetAll();
        }

        public void Update(T obj)
        {
            _rep.Update(obj);
        }

        public T GetById(int id)
        {
            return _rep.Get(id);
        }

        public void Remove(T obj)
        {
            _rep.Remove(obj);
        }

        public void RemoveById(int id)
        {
            T obj = this.GetById(id);
            if (obj == null)
                throw new Exception();
            this.Remove(obj);
        }

        public void Dispose()
        {
            _rep.Dispose();
        }
    }
}
