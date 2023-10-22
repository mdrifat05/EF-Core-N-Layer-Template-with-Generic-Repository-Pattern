using EFConfigureExample.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace EFConfigureExample.DataAccessLayer
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
                
        }

        public DbSet<User> Users { get; set; }
    }
}