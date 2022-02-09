using Microsoft.AspNetCore.Mvc;
using TODO.Application.Abstractions;

namespace TODO.API.Controllers
{
    [ApiController]
    public class ProjectController : Controller
    {
        private readonly IProjectService _projectService;

        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        public IActionResult Get()
        {
            var projects = _projectService.Get();
            return Ok(projects);
        }
    }
}