using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gameport.MvcWebUI.Areas.Management.Controllers
{
    public class AdminController : Controller
    {
        // GET: Management/Admin
        [HttpGet]
        public ActionResult Index()
        {

            return View();
        }
       [HttpPost]
        public ActionResult Index(FileResult form__img_upload)
        {
           
            return View();
        }
    }
}