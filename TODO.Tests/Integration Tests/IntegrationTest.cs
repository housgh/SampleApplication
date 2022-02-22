using System.Net.Http;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using TODO.API;
using TODO.Persistence.Contexts;

namespace TODO.Tests.Integration_Tests
{
    public class IntegrationTest
    {
        protected readonly HttpClient _client;
        
        protected IntegrationTest()
        {
            var webAppFactory = new WebApplicationFactory<Startup>()
                .WithWebHostBuilder(builder =>
                {
                    builder.ConfigureServices(services =>
                    {
                        services.RemoveAll(typeof(TasksDbContext));
                        services.AddDbContext<TasksDbContext>(options => 
                            options.UseInMemoryDatabase("TasksDB"));
                    });
                });
            _client = webAppFactory.CreateClient();
        }
    }
}