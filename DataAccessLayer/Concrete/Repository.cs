using DataAccessLayer.Abtract;
using DataAccessLayer.EntityFrameworkSQL;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Repository<T> :Singleton, IRepository<T> where T : class
    {
        
        private DbSet<T> _object;
       
        public Repository()
        {

            _object = _context.Set<T>();
        }
        public int Delete(T entity)
        {
            _object.Remove(entity);
            return Save();
        }

        public T Find(Expression<Func<T, bool>> filter)
        {
            return _object.FirstOrDefault(filter);
        }

        public T GetById(int id)
        {

            T result = _object.Find(id);
            return result;
        }

        public void Insert(T entity)
        {
            _object.Add(entity);
            Save();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public IQueryable<T> ListQueryable(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter);
        }

        public IQueryable<T> ListQueryable()
        {
            return _object.AsQueryable<T>();
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public void Update(T entity)
        {
             Save();
        }

      
    }
}
