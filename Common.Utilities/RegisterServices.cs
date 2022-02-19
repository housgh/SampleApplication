using Common.Utilities.Services;
using Microsoft.Extensions.DependencyInjection;
using TODO.Application.Abstractions;

namespace Common.Utilities
{
    public static class RegisterServices
    {
        public static void RegisterCommonServices(this IServiceCollection services)
        {
            services.AddScoped<IHashingService, HashingService>();
        }
    }
}