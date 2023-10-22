using EFConfigureExample.BusinessLogicLayer.Abstraction;
using EFConfigureExample.DataAccessLayer.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFConfigureExample.DataAccessLayer.Abstraction;

namespace EFConfigureExample.BusinessLogicLayer.Service.Base
{
    public class BaseService<T> : IService<T> where T : class
    {
        IGenericRepository<T> _Repository;
        public BaseService(IGenericRepository<T> Repository) 
        {
            _Repository = Repository;
        }
        public virtual bool Add(T entity)
        {
           return _Repository.Create(entity);
        }

        public virtual bool Delete(T entity)
        {
           return _Repository.Delete(entity);
        }

        public virtual IEnumerable<T> GetAll()
        {
           return _Repository.GetAll();
        }

        public virtual bool Update(T entity)
        {
           return _Repository.Update(entity);
        }
    }
}
