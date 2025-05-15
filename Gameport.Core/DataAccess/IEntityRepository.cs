using Gameport.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Gameport.Core.DataAccess
{
   public interface IEntityRepository<T>
        where T:class,IEntity,new()
    {
        /// <summary>
        /// Tümünü listeleme methodu
        /// </summary>
        /// <param name="filter">Linq sorgusu ile gönderilen paramatre null olabilir</param>
        /// <returns></returns>
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        /// <summary>
        /// Tekli listeleme
        /// </summary>
        /// <param name="filter">Linq sorgusu parametre zorunlu</param>
        /// <returns></returns>
        T Get(Expression<Func<T, bool>> filter);
        /// <summary>
        /// Ekleme methodu
        /// </summary>
        /// <param name="entity"></param>
        void Add(T entity);
        /// <summary>
        /// Güncelleme methodu
        /// </summary>
        /// <param name="entity"></param>
        void Update(T entity);
        /// <summary>
        /// Silme methodu
        /// </summary>
        /// <param name="entity"></param>
        void Delete(T entity);
    }
}
