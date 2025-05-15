using Gameport.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameport.Entities.Concrete
{
   public class Category:IEntity
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Picture { get; set; }
        public string Category_Slider { get; set; }
        public string Category_Poster { get; set; }
    }
}
