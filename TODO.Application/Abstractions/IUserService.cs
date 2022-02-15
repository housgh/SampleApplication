using System.Threading.Tasks;
using TODO.Application.Models;

namespace TODO.Application.Abstractions
{
    public interface IUserService
    {
        Task<bool> AddUser(UserDTO userDto);
    }
}