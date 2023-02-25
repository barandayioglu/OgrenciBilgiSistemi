using DataAccessLayer.Abtract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BaseManager<T> : IRepository<T> where T : class
    {
        private Repository<T> repository = new Repository<T>();
        public int Delete(T entity)
        {
            return repository.Delete(entity);
        }

        public T Find(Expression<Func<T, bool>> filter)
        {
            return repository.Find(filter);
        }

        public T GetById(int id)
        {
            return repository.GetById(id);
        }

        public void Insert(T entity)
        {
            repository.Insert(entity);
        }

        public List<T> List()
        {
            return repository.List();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> ListQueryable(Expression<Func<T, bool>> filter)
        {
            return repository.ListQueryable(filter);
        }

        public IQueryable<T> ListQueryable()
        {
            return repository.ListQueryable();
        }

        public int Save()
        {
            return repository.Save();
        }

        public void Update(T entity)
        {
          repository.Update(entity);
        }
    }
}
