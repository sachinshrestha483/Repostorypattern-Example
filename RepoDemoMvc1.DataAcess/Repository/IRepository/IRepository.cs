using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RepoDemoMvc1.DataAcess.Repository.IRepository
{
   public interface IRepository<T> where T :class 
    {
        T Get(int id);

        IEnumerable<T> GetAll();
        T GetFirstOrDefault(Expression<Func<T,bool>>predicate);

        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);



        void Add(T entity);
        void Remove(int id);

        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entity);

    }
}
