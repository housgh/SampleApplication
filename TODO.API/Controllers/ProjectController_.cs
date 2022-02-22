using Common.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TODO.Application.Services;
using TODO.Persistence.Contexts;
using TODO.Persistence.Repositories;

namespace TODO.API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ProjectController_ : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            var dbOptions = new DbContextOptions<TasksDbContext>();
            var dbContext = new TasksDbContext(dbOptions);
            var repository = new Repository<Project, int>(dbContext);
            var projectService = new ProjectService(repository);
            var projects = projectService.Get();
            return Ok(projects);
        }
    }
}