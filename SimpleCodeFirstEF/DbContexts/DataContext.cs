global using Microsoft.EntityFrameworkCore;
using SimpleCodeFirstEF.Entities;

namespace SimpleCodeFirstEF.DbContexts
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions options)
            : base(options)
        {
            
        }

        public DbSet<History> Histories => Set<History>();
        public DbSet<StatusCode> StatusCodes => Set<StatusCodes>();
        public DbSet<UserTask> UserTasks => Set<UserTask>();
        public DbSet<User> Users => Set<User>();


    }
}
