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
        private readonly IReadWriteService _rws;

        public UserTaskService(
            IRepository<UserTask, int> userTaskRepository, 
            IRepository<User, int> userRepository,
            IReadWriteService rws)
        {
            _userTaskRepository = userTaskRepository;
            _userRepository = userRepository;
            _rws = rws;
        }
        
        public async Task AssignTaskToUser(UserTaskDTO taskDTO, UserDTO userDTO)
        {
            var task = await _userTaskRepository.GetAsync(taskDTO.Id);
            var user = await _userRepository.GetAsync(userDTO.Id);

            task.AssignedTo = user;
            _userTaskRepository.UpdateAsync(task);
            _rws.WriteToFile(JsonSerializer.Serialize(task), "/some/path/to/file");
        }
    }
}