using EFConfigureExample.DataAccessLayer.Abstraction;
using EFConfigureExample.DataAccessLayer.Models;
using EFConfigureExample.DataAccessLayer.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConfigureExample.DataAccessLayer.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        readonly ApplicationDbContext _db;

        public UserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;      
        }

        public User GetById(int id)
        {
            return _db.Users.FirstOrDefault(u => u.Id == id);
        }
    }
}
