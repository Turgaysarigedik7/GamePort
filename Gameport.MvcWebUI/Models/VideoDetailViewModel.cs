using Gameport.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gameport.MvcWebUI.Models
{
    public class VideoDetailViewModel
    {
        public int ID { get; set; }
        public Video VideoDetails { get; set; }
    }
}