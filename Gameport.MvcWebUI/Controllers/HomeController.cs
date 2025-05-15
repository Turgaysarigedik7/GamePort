using Gameport.Business.Abstract;
using Gameport.Core.CrossCuttingConcerns.Security;
using Gameport.Core.CrossCuttingConcerns.Security.Web;
using Gameport.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Web;
using System.Web.Mvc;

namespace Gameport.MvcWebUI.Controllers
{
    public class HomeController : Controller
    {
        private IVideoService _videoService;
        public HomeController(IVideoService videoService)
        {
            _videoService = videoService;
        }
        // GET: Home 
        public ActionResult Index()
        {
                var model = new VideoListViewModel
                {
                    Videos = _videoService.GetList(),
                    Categories = _videoService.GetVideoDetails()
                };

                return View(model);
        }
       
    }
}