using Microsoft.Extensions.DependencyInjection;
using TODO.Application.Abstractions;
using TODO.Application.Services;

namespace TODO.Application
{
    public static class RegisterServices
    {
        public static void RegisterApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<IProjectUserService, ProjectUserService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserTaskService, UserTaskService>();
        }
    }
}
