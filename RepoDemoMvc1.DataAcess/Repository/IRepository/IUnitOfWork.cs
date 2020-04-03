using RepoDemoMvc1.DataAcess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepoDemoMvc1.DataAcess.Repository
{
    public interface IUnitOfWork:IDisposable
    {

        ICategoryRepository Category { get; }
        IAuthorRepository Author { get; }

        void Save();

    }
}
