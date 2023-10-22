using EFConfigureExample.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConfigureExample.BusinessLogicLayer.Abstraction
{
    public interface IUserService : IService<User>
    {
        User GetById(int id);
    }
}
