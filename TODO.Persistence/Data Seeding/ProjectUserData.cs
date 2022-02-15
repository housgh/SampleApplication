using System.Collections.Generic;
using Common.Domain.Entities;
using Common.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace TODO.Persistence.Data_Seeding
{
    internal static class ProjectUserData
    {
        public static void SeedProjectUserData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProjectUser>().HasData(new List<ProjectUser>()
            {
                new ProjectUser() {Id = 1, ProjectId = 1, UserId = 1, Role = UserRole.Owner},
                new ProjectUser() {Id = 2, ProjectId = 2, UserId = 2, Role = UserRole.Owner},
                new ProjectUser() {Id = 3, ProjectId = 1, UserId = 2, Role = UserRole.Member},
                new ProjectUser() {Id = 4, ProjectId = 2, UserId = 1, Role = UserRole.Member},
                new ProjectUser() {Id = 5, ProjectId = 2, UserId = 3, Role = UserRole.ReadOnly},
            });
        }
    }
}