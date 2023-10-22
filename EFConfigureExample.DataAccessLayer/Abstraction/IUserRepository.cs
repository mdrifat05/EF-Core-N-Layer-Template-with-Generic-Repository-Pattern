using EFConfigureExample.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConfigureExample.DataAccessLayer.Abstraction
{
    public interface IUserRepository : IGenericRepository<User>
    {
        User GetById(int id);
    }
}
