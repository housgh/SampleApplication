using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Protocols;
using TODO.Application.Abstractions;
using TODO.Persistence.Caching;
using TODO.Persistence.Contexts;
using TODO.Persistence.Repositories;

namespace TODO.Persistence
{
    public static class RegisterServices
    {
        public static void RegisterPersistanceServices(
            this IServiceCollection services, 
            IConfiguration configuration)
        {
            services.AddScoped<ICachingService, CachingService>();
            services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));

            services.AddDbContext<TasksDbContext>(options => 
                    options.UseSqlServer(configuration.GetConnectionString("Tasks")));
        }
    }
}
