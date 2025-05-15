using Gameport.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameport.Core.DataAccess.EntityFramework
{
    public class EfQuaryableRepository<T> : IQuaryableRepository<T>
         where T : class, IEntity, new()
    {
        private DbContext _dbContext;
        private IDbSet<T> _entities;
        public EfQuaryableRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IQueryable<T> Table => this.Entities;

        protected virtual IDbSet<T> Entities
        {
            get { return _entities ?? (_entities = _dbContext.Set<T>()); }
        }
    }
}
