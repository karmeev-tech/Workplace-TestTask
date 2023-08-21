using Microsoft.EntityFrameworkCore;
using Workplace.Infrastructure.Model;
using Workplace.Infrastructure.Persistence.Configuration;

namespace Workplace.Infrastructure.Persistence
{
    public class UserContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }
        public string DbPath 
        { 
            get => PersistanceConfiguration.Configure(); }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
    }
}
