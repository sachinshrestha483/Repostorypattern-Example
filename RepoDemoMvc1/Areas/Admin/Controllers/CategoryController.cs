using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RepoDemoMvc1.DataAcess.Repository;
using RepoDemoMvc1.Models;

namespace RepoDemoMvc1.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
           this. _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var Categories = _unitOfWork.Category.GetFirstOrDefault(t=>t.Numb==1);
            return View(Categories);
        }
    }
}