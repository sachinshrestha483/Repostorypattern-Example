using Microsoft.EntityFrameworkCore;
using RepoDemoMvc1.DataAcess.Data;
using RepoDemoMvc1.DataAcess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RepoDemoMvc1.DataAcess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {

        public readonly ApplicationDbContext _db;

        internal DbSet<T> dbSet;
        public Repository(ApplicationDbContext db)
        {
            _db = db;
            this.dbSet = _db.Set<T>();
        }
        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = dbSet;

            query.Where(predicate);

            return query.ToList();

         }

        public T Get(int id)
        {
            return dbSet.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            IEnumerable<T> list = dbSet;
            return list.ToList();
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = dbSet;

           return query.Where(predicate).FirstOrDefault();

            
        }

        public void Remove(int id)
        {
            T entity = dbSet.Find(id);

            Remove(entity);
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entity)
        {


            dbSet.RemoveRange(entity);
        }
    }
}
