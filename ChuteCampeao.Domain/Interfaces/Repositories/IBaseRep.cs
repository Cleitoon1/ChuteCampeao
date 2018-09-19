
using System.Collections.Generic;
using System.Linq;

namespace ChuteCampeao.Domain.Interfaces.Repositories
{
    public interface IBaseRep<T> where T : class
    {
        void Insert(T obj);

        T Get(int id);

        IEnumerable<T> GetPaginated(IQueryable<T> query, string filter, bool isDescending, int initialPage, int pageSize);

        IEnumerable<T> GetAll();

        void Update(T obj);

        void Remove(T obj);

        void Dispose();
    }
}
