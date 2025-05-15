using Gameport.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameport.Entities.Concrete
{
   public class Video:IEntity
    {
        public int VideoID { get; set; }
        public int CategoryID { get; set; }
        public string VideoName { get; set; }
        public string Adress { get; set; }
        public string Poster { get; set; }
    }
}
