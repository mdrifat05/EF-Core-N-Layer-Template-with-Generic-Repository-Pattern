using EFConfigureExample.DataAccessLayer.Abstraction;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConfigureExample.DataAccessLayer.Repository.Base
{
    public abstract class BaseRepository<T> : IGenericRepository<T> where T : class
    {
        readonly DbContext _db;
        public BaseRepository(DbContext db) 
        { 
            _db = db;
        }

        public DbSet<T> Table
        {
            get { return _db.Set<T>(); }
        }
        public bool Create(T entity)
        {
             Table.Add(entity);
            return _db.SaveChanges() > 0;
        }

        public bool Delete(T entity)
        {
            Table.Remove(entity);
            return _db.SaveChanges() > 0;
        }

        public IEnumerable<T> GetAll()
        {
           return Table.ToList();
        }

        public bool Update(T entity)
        {
           Table.Update(entity);
            return _db.SaveChanges() > 0;
        }
    }
}
