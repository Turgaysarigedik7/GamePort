using Gameport.Core.DataAccess;
using Gameport.Entities.ComplexType;
using Gameport.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameport.DataAccess.Abstract
{
   public interface IVideoDal:IEntityRepository<Video>
    {
        List<CategoryList> GetVideoDetails();
    }
}
