using Gameport.Business.Abstract;
using Gameport.Business.Concrete.Managers;
using Gameport.Core.DataAccess;
using Gameport.Core.DataAccess.EntityFramework;
using Gameport.DataAccess.Abstract;
using Gameport.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameport.Business.DependecyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICategoryDal>().To<EfCategoryDal>().InSingletonScope();
            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();

            Bind<IVideoDal>().To<EfVideoDal>().InSingletonScope();
            Bind<IVideoService>().To<VideoManager>().InSingletonScope();

            Bind<IUserDal>().To<EfUserDal>().InSingletonScope();
            Bind<IUserService>().To<UserManager>().InSingletonScope();

            Bind(typeof(IQuaryableRepository<>)).To(typeof(EfQuaryableRepository<>)).InSingletonScope();
            Bind<DbContext>().To<GameportDBContext>().InSingletonScope();


        }
    }
}
