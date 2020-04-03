using RepoDemoMvc1.DataAcess.Data;
using RepoDemoMvc1.DataAcess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepoDemoMvc1.DataAcess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;


        public UnitOfWork(ApplicationDbContext db)
        { 
            _db = db;

            Category = new CategoryRepository(_db);

            Author = new AuthorRepository(_db);
           
        }

        public ICategoryRepository Category { get; private set; }

        public IAuthorRepository Author { get; private set; }


        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
