using Microsoft.EntityFrameworkCore;
using DatingApp.API.Model;

namespace DatingApp.API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public virtual DbSet<Value> Values { get; set; }
        public virtual DbSet<User> Users {get; set;}

   
    }
}