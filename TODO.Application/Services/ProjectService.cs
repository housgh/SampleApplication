using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Domain.Entities;
using TODO.Application.Abstractions;
using TODO.Application.Models;

namespace TODO.Application.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IRepository<Project, int> _repository;

        public ProjectService(IRepository<Project, int> repository)
        {
            _repository = repository;
        }
        
        public async Task<List<ProjectDTO>> Get()
        {
            var projects = await _repository.GetAsync();
            return projects.Select(project => new ProjectDTO()
            {
                Id = project.Id,
                Description = project.Description,
                Name = project.Name,
                OwnerId = project.OwnerId
            }).ToList();
        }
    }
}