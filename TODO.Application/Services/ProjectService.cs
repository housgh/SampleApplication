using System.Collections.Generic;
using TODO.Application.Abstractions;
using TODO.Application.Models;

namespace TODO.Application.Services
{
    public class ProjectService : IProjectService
    {
        private readonly List<ProjectDTO> projects = new List<ProjectDTO>()
        {
            new ProjectDTO(){Id = 1, Name = "Project1", Description = "Some Project", OwnerId = 1},
            new ProjectDTO(){Id = 2, Name = "Project1", Description = "Some Project", OwnerId = 2},
            new ProjectDTO(){Id = 3, Name = "Project1", Description = "Some Project", OwnerId = 3},
        };
        
        public List<ProjectDTO> Get()
        {
            return projects;
        }
    }
}