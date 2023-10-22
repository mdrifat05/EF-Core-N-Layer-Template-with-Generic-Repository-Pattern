using EFConfigureExample.BusinessLogicLayer.Abstraction;
using EFConfigureExample.BusinessLogicLayer.Service.Base;
using EFConfigureExample.DataAccessLayer.Abstraction;
using EFConfigureExample.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConfigureExample.BusinessLogicLayer.Service
{
    public class UserService :BaseService<User>, IUserService
    {
        readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository) : base(userRepository)
        {
            _userRepository = userRepository;    
        }

        public User GetById(int id)
        {
          return _userRepository.GetById(id);
        }
    }
}
