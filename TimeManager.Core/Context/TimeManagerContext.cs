using Microsoft.EntityFrameworkCore;
using TimeManager.Core.Entity;

namespace TimeManager.Core.Context
{
    public class TimeManagerContext: DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<RegularTask> RegularTasks { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=TimeManager;Trusted_Connection=True;TrustServerCertificate=True;");
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }
    }
}
