using Gameport.Business.Abstract;
using Gameport.Core.Aspect.Postsharp.AuthorizationAspects;
using Gameport.DataAccess.Abstract;
using Gameport.Entities.ComplexType;
using Gameport.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Gameport.Business.Concrete.Managers
{
    [SecuredOperaiton(Roles = "Admin,Standart")]
   
    public class VideoManager : IVideoService
    {
        private IVideoDal _videoDal;
        public VideoManager(IVideoDal videoDal)
        {
            _videoDal = videoDal;
        }
        public void Add(Video video)
        {
            _videoDal.Add(video);
        }

        public void Delete(Video video)
        {
            _videoDal.Delete(video);
        }

        public Video GetById(int id)
        {
            return _videoDal.Get(v => v.VideoID == id);
        }
        
        public List<Video> GetList(Expression<Func<Task, bool>> filter = null)
        {
            return _videoDal.GetAll();
        }
       
        public List<CategoryList> GetVideoDetails()
        {
            return _videoDal.GetVideoDetails();
        }

        public void Update(Video video)
        {
            _videoDal.Update(video);
        }
    }
}
