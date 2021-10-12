
using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Database.Context
{
    public class DataContext : DbContext
    {

        public DbSet<UsersModel> Users { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
                      
        }
    }
}
