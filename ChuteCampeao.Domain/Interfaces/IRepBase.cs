﻿
using System.Collections.Generic;

namespace ChuteCampeao.Domain.Interfaces
{
    public interface IRepBase<T> where T : class
    {
        void Insert(T obj);

        T Get(int id);

        IEnumerable<T> GetAll();

        void Update(T obj);

        void Remove(T obj);

        void Dispose();
    }
}
