using System.Threading.Tasks;
using Common.Domain.Entities;
using TODO.Application.Abstractions;
using TODO.Application.Models;

namespace TODO.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User, int> _repository;
        private readonly IHashingService _hashingService;

        public UserService(IRepository<User, int> repository, IHashingService hashingService)
        {
            _repository = repository;
            _hashingService = hashingService;
        }

        public async Task<bool> AddUser(UserDTO userDto)
        {
            var hashedPassword = _hashingService.HashPassword(userDto.Password);
            var user = new User()
            {
                Email = userDto.Email.Value,
                Mobile = userDto.Mobile,
                Name = userDto.Name,
                Role = userDto.Role,
                HashedPassword = hashedPassword
            };
            var rowsAffected = await _repository.AddAsync(user);
            return rowsAffected > 0;
        }
    }
}