using Microsoft.Extensions.DependencyInjection;
using TODO.Application.Abstractions;
using TODO.Infrastructure.File_Services;
using TODO.Infrastructure.Notification_Services;
using TODO.Infrastructure.Third_Party_Services;

namespace TODO.Infrastructure
{
    public static class RegisterServices
    {
        public static void RegisterInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<IExternalDataService, ExternalDataService>();
            services.AddScoped<IWriteService, WriteService>();
            services.AddScoped<ISMSService, SMSService>();
            services.AddScoped<IReadService, ReadService>();
        }
    }
}
