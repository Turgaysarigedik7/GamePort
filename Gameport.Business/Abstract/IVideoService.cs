using Gameport.Entities.ComplexType;
using Gameport.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Gameport.Business.Abstract
{
   public interface IVideoService
    {
        List<Video> GetList(Expression<Func<Task,bool>> filter=null);
        Video GetById(int id);
        void Add(Video video);
        void Update(Video video);
        void Delete(Video video);
        List<CategoryList> GetVideoDetails();
    }
}
