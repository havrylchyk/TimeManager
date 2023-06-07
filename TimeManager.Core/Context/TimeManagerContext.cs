using Microsoft.EntityFrameworkCore;
using TimeManager.Core.Entity;

namespace TimeManager.Core.Context
{
    public class TimeManagerContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<SportTasks> Tasks { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<RegularTask> RegularTasks { get; set; }
        public DbSet<HouseholdTasks> HouseholdTasks { get; set; }
        public DbSet<LeisureTasks> LeisureTasks { get; set; }
        public DbSet<StudyTasks> StudyTasks { get; set; }
        public DbSet<WorkTasks> WorkTasks { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=TimeManager;Trusted_Connection=True;TrustServerCertificate=True;");
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }
    }
}
