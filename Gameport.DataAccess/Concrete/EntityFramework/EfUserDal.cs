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
    public class EfUserDal : EfEntityRepositoryBase<User, GameportDBContext>, IUserDal
    {
        public List<UserRoleItem> GetUserRoles(User user)
        {
            using (GameportDBContext context=new GameportDBContext())
            {
                var result = from ur in context.UserRoles
                             join r in context.Roles
                             on ur.UserId equals user.Id
                             where ur.UserId == user.Id
                             select new UserRoleItem { RoleName = r.Name };
                return result.ToList();
            }
        }
    }
}
