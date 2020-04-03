using RepoDemoMvc1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepoDemoMvc1.DataAcess.Repository.IRepository
{
    public interface IAuthorRepository : IRepository<Author>
    {

        IEnumerable<Author>  AuthorWithNCourses(int n);
       // IEnumerable<Author> AuthorWithNCourses(int n);
    }
}
