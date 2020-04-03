using RepoDemoMvc1.DataAcess.Data;
using RepoDemoMvc1.DataAcess.Repository.IRepository;
using RepoDemoMvc1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepoDemoMvc1.DataAcess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {



        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base(db)
        {

                     _db=db;
        }



      


        public void Update(Category category)
        {

            var objFromDb = _db.Categories.FirstOrDefault(c=>c.Id==category.Id);
            if(objFromDb!=null)
            {
                objFromDb.Name = category.Name;
            }

        }
    }
}
