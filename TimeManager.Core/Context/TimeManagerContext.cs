using Microsoft.EntityFrameworkCore;
using TimeManager.Core.Entity;

namespace TimeManager.Core.Context
{
    public class TimeManagerContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<TaskCategory> TaskCategory { get; set; }
        public DbSet<TasksStatus> TaskStatus { get; set; }
        public DbSet<RegularTask> RegularTasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TasksStatus>().HasData(
                new TasksStatus { StasusName = "Не розпочато" },
                new TasksStatus { StasusName = "В процесі" },
                new TasksStatus { StasusName = "Виконано" }
            );

            modelBuilder.Entity<TaskCategory>().HasData(
                new TaskCategory { CategoryName = "Спорт" },
                new TaskCategory { CategoryName = "Навчання" },
                new TaskCategory { CategoryName = "Робота" },
                new TaskCategory { CategoryName = "Домашні обов'язки" },
                new TaskCategory { CategoryName = "Дозвілля" }
                );
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=TimeManager;Trusted_Connection=True;TrustServerCertificate=True;");
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }
    }
}
