using System.Threading.Tasks;
using Common.Domain.Value_Objects;
using Microsoft.AspNetCore.Mvc;
using TODO.API.View_Models;
using TODO.Application.Abstractions;
using TODO.Application.Models;

namespace TODO.API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        
        [HttpPost]
        public async Task<IActionResult> CreateUser(UserVM userVM)
        {
            var userDTO = new UserDTO()
            {
                Name = userVM.Name,
                Mobile = userVM.Mobile,
                Password = userVM.Password,
                JoinedOn = userVM.JoinedOn,
                Role = userVM.Role,
                TasksLimit = 0,
                Email = Email.From(userVM.Email)
            };
            var result = await _userService.AddUser(userDTO);
            return result ? Ok() : BadRequest();
        } 
    }
}