using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TODO.Application.Abstractions;

namespace TODO.API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ProjectController : Controller
    {
        private readonly IProjectService _projectService;

        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }
        
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var projects = await _projectService.Get();
            return Ok(projects);
        }
    }
}