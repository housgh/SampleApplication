using System.Collections.Generic;
using System.Threading.Tasks;
using TODO.Application.Models;

namespace TODO.Application.Abstractions
{
    public interface IProjectService
    {
        Task<List<ProjectDTO>> Get();
    }
}