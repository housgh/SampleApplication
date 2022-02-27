using System.Text.Json;
using System.Threading.Tasks;
using Common.Domain.Entities;
using TODO.Application.Abstractions;
using TODO.Application.Exceptions;
using TODO.Application.Models;

namespace TODO.Application.Services
{
    public class UserTaskService : IUserTaskService
    {
        private readonly IRepository<UserTask, int> _userTaskRepository;
        private readonly IRepository<User, int> _userRepository;
        private readonly IWriteService _ws;

        public UserTaskService(
            IRepository<UserTask, int> userTaskRepository, 
            IRepository<User, int> userRepository,
            IWriteService ws)
        {
            _userTaskRepository = userTaskRepository;
            _userRepository = userRepository;
            _ws = ws;
        }
        
        public async Task AssignTaskToUser(UserTaskDTO taskDto, UserDTO userDto)
        {
            var assignedTasks = await _userTaskRepository.FindAllAsync(t => t.AssignedToId == userDto.Id);

            if (assignedTasks.Count == userDto.TasksLimit)
            {
                throw new TaskLimitExceededException($"{userDto.Name} is limited to {userDto.TasksLimit} tasks only.");
            }
            
            var task = await _userTaskRepository.GetAsync(taskDto.Id);
            var user = await _userRepository.GetAsync(userDto.Id);

            task.AssignedTo = user;
            await _userTaskRepository.UpdateAsync(task);
            _ws.WriteToFile(JsonSerializer.Serialize(task), "/some/path/to/file");
        }
    }
}