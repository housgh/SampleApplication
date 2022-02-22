using Common.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TODO.Persistence.Data_Seeding;

namespace TODO.Persistence.Contexts
{
    public class TasksDbContext : DbContext
    {
        public TasksDbContext(DbContextOptions<TasksDbContext> options) : base(options) {}

        public virtual DbSet<UserTask> Tasks { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<ProjectUser> ProjectUsers { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedUserData();
            modelBuilder.SeedProjectData();
            modelBuilder.SeedProjectUserData();
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
            base.OnModelCreating(modelBuilder);
        }
    }
}