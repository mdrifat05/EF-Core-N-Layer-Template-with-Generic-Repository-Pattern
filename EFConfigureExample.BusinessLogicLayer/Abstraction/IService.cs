using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConfigureExample.BusinessLogicLayer.Abstraction
{
    public interface IService<T> where T : class
    {
        IEnumerable<T> GetAll();    
        bool Add(T entity);
        bool Delete(T entity);
        bool Update(T entity);
    }
}
