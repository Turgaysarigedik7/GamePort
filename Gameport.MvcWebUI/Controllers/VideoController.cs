using Gameport.Business.Abstract;
using Gameport.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gameport.MvcWebUI.Controllers
{
    public class VideoController : Controller
    {
        private IVideoService _videoService;
        public VideoController(IVideoService videoService)
        {
            _videoService = videoService;
        }
        // GET: Video
        public ActionResult Index(int id)
        {
            var model = new VideoDetailViewModel
            {
                ID=id,
                VideoDetails = _videoService.GetById(id)
            };
            return View(model);
        }
        public ActionResult GetDetail(int id)
        {
            var model = new VideoDetailViewModel
            {
                ID = id,
                VideoDetails = _videoService.GetById(id)
            };
            return View(model);
        }
    }
}