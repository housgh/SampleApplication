using System;
using System.Collections.Generic;
using Common.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace TODO.Persistence.Data_Seeding
{
    internal static class UserData
    {
        public static void SeedUserData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new List<User>()
            {
                new User()
                {
                    Id = 1, Name = "User1", Email = "user1@todoapp.com", Mobile = "+96171234567",
                    JoinedOn = DateTime.Now,
                    HashedPassword = ""
                },
                new User()
                {
                    Id = 2, Name = "User2", Email = "user2@todoapp.com", Mobile = "+96171234568",
                    JoinedOn = DateTime.Now,
                    HashedPassword = ""
                },
                new User()
                {
                    Id = 3, Name = "User3", Email = "user3@todoapp.com", Mobile = "+96171234569",
                    JoinedOn = DateTime.Now,
                    HashedPassword = ""
                },
                new User()
                {
                    Id = 4, Name = "User4", Email = "user4@todoapp.com", Mobile = "+96171234560",
                    JoinedOn = DateTime.Now,
                    HashedPassword = ""
                },
                new User()
                {
                    Id = 5, Name = "User5", Email = "user5@todoapp.com", Mobile = "+96171234571",
                    JoinedOn = DateTime.Now,
                    HashedPassword = ""
                },
                new User()
                {
                    Id = 6, Name = "User6", Email = "user6@todoapp.com", Mobile = "+96171234572",
                    JoinedOn = DateTime.Now,
                    HashedPassword = ""
                }
            });
        }
    }
}