using System;
using System.Linq;
using System.Linq.Expressions;

namespace Domain.Data
{
    public interface IRepository<T>
    {
        IQueryable<T> SelectAll();

        IQueryable<T> SelectWhere(Expression<Func<T, bool>> where);

        T SelectSingle(Expression<Func<T, bool>> where);


            void Add(T entity);

            void Delete(T entity);

            void Attach(T entity);

            void SaveChanges();

    }
}
