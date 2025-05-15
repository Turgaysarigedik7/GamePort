using Gameport.Entities.ComplexType;
using Gameport.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gameport.MvcWebUI.Models
{
    public class VideoListViewModel
    {
        public List<Video> Videos { get; set; }
        public List<CategoryList> Categories { get; set; }
    }
}