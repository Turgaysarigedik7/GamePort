using Gameport.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gameport.MvcWebUI.Controllers
{
    public class VideoDetailController : Controller
    {
        // GET: VideoDetail
        public ActionResult Index(int id)
        {
            var model = new VideoDetailViewModel
            {
                ID = id
            };
            return View(model);
        }
    }
}