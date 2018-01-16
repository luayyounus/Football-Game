using System;
using FootballDeployment.Controllers;
using FootballDeployment.Data;
using FootballDeployment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace XUnitTestFootballDeployment
{
    public class TestHome
    {
        FootballDbContext _context;
        public TestHome()
        {
            DbContextOptionsBuilder<FootballDbContext> builder = new DbContextOptionsBuilder<FootballDbContext>();
            builder.UseInMemoryDatabase(Guid.NewGuid().ToString());
            DbContextOptions<FootballDbContext> options = builder.Options;
            _context = new FootballDbContext(options);
        }

        [Fact]
        public void Home_Index_Returns_View()
        {
            // Arrange
            HomeController homeController = new HomeController(_context);

            // Act
            var result = homeController.Index();

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void Redirect_To_Team_Info()
        {
            // Arrange
            Team team = new Team { Name = "Banana", Country = "Cloud", Field = "CPU", Id = 2 };
            HomeController homeController = new HomeController(_context);

            // Act
            var result = homeController.Index(team);


            // Assert
            var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Team", redirectToActionResult.ControllerName);
            Assert.Equal("TeamInfo", redirectToActionResult.ActionName);
        }
    }
}
