using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConfigureExample.DataAccessLayer.Abstraction
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(T entity);
    }
}
