using System.Collections.Generic;
using TODO.Application.Models;

namespace TODO.Application.Abstractions
{
    public interface IProjectService
    {
        List<ProjectDTO> Get();
    }
}