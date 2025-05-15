using Gameport.Core.DataAccess.EntityFramework;
using Gameport.DataAccess.Abstract;
using Gameport.Entities.ComplexType;
using Gameport.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameport.DataAccess.Concrete.EntityFramework
{
    public class EfVideoDal : EfEntityRepositoryBase<Video, GameportDBContext>, IVideoDal
    {
        public List<CategoryList> GetVideoDetails()
        {
            using (GameportDBContext context=new GameportDBContext())
            {
                var result = from v in context.Categories
                             select new CategoryList
                             {
                                 CategoryID = v.CategoryID,
                                 CategoryName = v.CategoryName,
                                 Picture = v.Picture,
                                 Category_Slider=v.Category_Slider
                             };

                return result.ToList(); 
            }
        }
    }
}
