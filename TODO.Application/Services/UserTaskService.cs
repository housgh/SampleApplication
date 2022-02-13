using System.Text.Json;
using System.Threading.Tasks;
using Common.Domain.Entities;
using TODO.Application.Abstractions;
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
        
        public async Task AssignTaskToUser(UserTaskDTO taskDTO, UserDTO userDTO)
        {
            var task = await _userTaskRepository.GetAsync(taskDTO.Id);
            var user = await _userRepository.GetAsync(userDTO.Id);

            task.AssignedTo = user;
            _userTaskRepository.UpdateAsync(task);
            _ws.WriteToFile(JsonSerializer.Serialize(task), "/some/path/to/file");
        }
    }
}