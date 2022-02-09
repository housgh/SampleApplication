using Microsoft.AspNetCore.Mvc;
using TODO.Application.Services;

namespace TODO.API.Controllers
{
    [ApiController]
    public class ProjectController_ : Controller
    {
        public IActionResult Get()
        {
            var projectService = new ProjectService();
            var projects = projectService.Get();
            return Ok(projects);
        }
    }
}