using System.Threading.Tasks;
using TODO.Application.Models;

namespace TODO.Application.Abstractions
{
    public interface IProjectUserService
    {
        Task<bool> AddProjectUser(ProjectDTO projectDto, UserDTO userDto);
    }
}