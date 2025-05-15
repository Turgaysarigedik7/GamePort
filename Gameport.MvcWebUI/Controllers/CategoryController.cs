using Gameport.Business.Abstract;
using Gameport.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gameport.MvcWebUI.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        // GET: Category
        public ActionResult Index()
        {
            var model = new CategoryListViewModel
            {
                Categories = _categoryService.GetList()
            };
            return View(model);
        }
    }
}