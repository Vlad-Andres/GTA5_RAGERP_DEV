using System;
using System.Collections.Generic;
using System.Text;

namespace GTA_RP {
    public interface IRepository<T> {
        void Add(T entity);
        void Update(T entity);
        IEnumerable<T> GetAll();
        void Remove(T entity);
        T GetById(int id);
    }
}
