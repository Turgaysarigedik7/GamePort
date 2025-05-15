using Gameport.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameport.Core.DataAccess
{
    public interface IQuaryableRepository<T>
        where T:class,IEntity,new()
    {
        IQueryable<T> Table { get; }
    }
}
