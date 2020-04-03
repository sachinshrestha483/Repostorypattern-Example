using RepoDemoMvc1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepoDemoMvc1.DataAcess.Repository.IRepository
{
   public interface ICategoryRepository: IRepository<Category>
    {
        void Update(Category category);

   }
}
