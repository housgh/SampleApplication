using System.Collections.Generic;
using System.Linq;
using Common.Domain.Entities;
using Moq;
using TODO.Application.Abstractions;
using TODO.Application.Models;
using TODO.Application.Services;
using Xunit;

namespace TODO.Tests.Unit_Tests
{
    public class ProjectServiceTests
    {
        private readonly ProjectService _projectService;
        private readonly Mock<IRepository<Project, int>> _mockRepository;

        public ProjectServiceTests()
        {
            _mockRepository = new Mock<IRepository<Project, int>>();
            _projectService = new ProjectService(_mockRepository.Object);
        }
        
        //AAA Testing Method
        [Fact]
        public async void Get_ShouldReturnAllProjects()
        {
            //Arrange
            var projects = new List<Project>()
            {
                new Project() { Id = 1, Description = "Some Description", Name = "Some Name", OwnerId = 1 }
            };
            _mockRepository.Setup(repo => repo.GetAsync()).ReturnsAsync(projects);

            //Act
            var result = await _projectService.Get();
            
            //Assert
            Assert.NotNull(result);
            Assert.True(result.Count > 0);
            Assert.Collection(result, element =>
            {
                Assert.Equal(1, element.Id);
                Assert.Equal("Some Description", element.Description);
                Assert.Equal("Some Name", element.Name);
                Assert.Equal(1, element.OwnerId);
            });
        }
    }
}