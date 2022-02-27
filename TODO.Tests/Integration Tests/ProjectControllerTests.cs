using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TODO.Application.Models;
using Xunit;

namespace TODO.Tests.Integration_Tests
{
    public class ProjectControllerTests : IntegrationTest
    {
        [Fact]
        public async Task Get_ShouldReturnTwoValues()
        {
            //Arrange
            const string requestUrl = "https://localhost:5001/api/Project";
            
            //Act
            var response = await _client.GetAsync(requestUrl);
            
            //Assert
            var projects = JsonConvert.DeserializeObject<List<ProjectDTO>>(await response.Content.ReadAsStringAsync());
            Assert.True(response.IsSuccessStatusCode);
            Assert.NotNull(projects);
        }
    }
}