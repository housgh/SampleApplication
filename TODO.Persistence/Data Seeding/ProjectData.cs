using System.Collections.Generic;
using Common.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace TODO.Persistence.Data_Seeding
{
    internal static class ProjectData
    {
        public static void SeedProjectData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().HasData(new List<Project>()
            {
                new Project()
                {
                    Id = 1, Name = "Sample Project 1", Description = "A sample project that does nothing", OwnerId = 1
                },
                new Project()
                {
                    Id = 2, Name = "Sample Project 2", Description = "A sample project that does nothing", OwnerId = 2
                }
            });
        }
    }
}