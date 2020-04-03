using Microsoft.EntityFrameworkCore;
using RepoDemoMvc1.DataAcess.Data;
using RepoDemoMvc1.DataAcess.Repository.IRepository;
using RepoDemoMvc1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepoDemoMvc1.DataAcess.Repository
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        private readonly ApplicationDbContext _db;

        public AuthorRepository(ApplicationDbContext db) : base(db)
        {

            _db = db;
        }


       

        IEnumerable<Author> IAuthorRepository.AuthorWithNCourses(int n)
        {
            List<Author> odb = _db.Authors.Where(t => t.CourseId == n).ToList();

            return odb;
        }
    }
}
