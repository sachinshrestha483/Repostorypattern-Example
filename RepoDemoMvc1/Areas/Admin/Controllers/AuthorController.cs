using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RepoDemoMvc1.DataAcess.Repository;

namespace RepoDemoMvc1.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class AuthorController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public AuthorController(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {

            var list = _unitOfWork.Author.AuthorWithNCourses(2);
            return View(list);
        }
    }
}