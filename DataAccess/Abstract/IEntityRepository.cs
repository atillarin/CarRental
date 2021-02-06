using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>>filter =null);//filter şart değil
        T Get(Expression<Func<T,bool>>filter); //filter şart
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
