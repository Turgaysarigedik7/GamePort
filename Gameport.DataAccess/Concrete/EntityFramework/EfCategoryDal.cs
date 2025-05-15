using Gameport.Core.DataAccess.EntityFramework;
using Gameport.DataAccess.Abstract;
using Gameport.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameport.DataAccess.Concrete.EntityFramework
{
   public class EfCategoryDal:EfEntityRepositoryBase<Category,GameportDBContext>,ICategoryDal
    {
    }
}
