using System.Threading.Tasks;
using Common.Domain.Entities;
using TODO.Application.Models;

namespace TODO.Application.Abstractions
{
    public interface IUserTaskService
    {
        Task AssignTaskToUser(UserTaskDTO task, UserDTO user);
    }
}