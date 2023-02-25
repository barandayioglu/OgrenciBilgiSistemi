using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abtract
{
    public interface IRepository<T>
    {
        // Birden fazla kayıt almak için
        List<T> List();
        List<T> List(Expression<Func<T, bool>> filter);
        T GetById(int id);
      
        void Insert(T entity);
        void Update(T entity);
        int Delete(T entity);
        int Save();
        T Find(Expression<Func<T, bool>> filter);
        IQueryable<T> ListQueryable(Expression<Func<T, bool>> filter);
        IQueryable<T> ListQueryable();
    }
}