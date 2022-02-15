using System.Threading.Tasks;
using Common.Domain.Entities;
using TODO.Application.Abstractions;
using TODO.Application.Models;

namespace TODO.Application.Services
{
    public class ProjectUserService : IProjectUserService
    {
        private readonly IRepository<ProjectUser, int> _repository;

        public ProjectUserService(IRepository<ProjectUser, int> repository)
        {
            _repository = repository;
        }

        public async Task<bool> AddProjectUser(ProjectDTO projectDto, UserDTO userDto)
        {
            var projectUser = new ProjectUser()
            {
                UserId = userDto.Id,
                ProjectId = projectDto.Id
            };

            var rowsAffected = await _repository.AddAsync(projectUser);
            return rowsAffected > 0;
        }
    }
}