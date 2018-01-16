using System;
using FootballDeployment.Controllers;
using FootballDeployment.Data;
using FootballDeployment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace XUnitTestFootballDeployment.TestTeamController
{
    public class TestTeam
    {
        FootballDbContext _context;
        TeamController teamController;

        public TestTeam()
        {
            DbContextOptionsBuilder<FootballDbContext> builder = new DbContextOptionsBuilder<FootballDbContext>();
            builder.UseInMemoryDatabase(Guid.NewGuid().ToString());
            DbContextOptions<FootballDbContext> options = builder.Options;
            _context = new FootballDbContext(options);
            teamController = new TeamController(_context);
        }

        [Fact]
        public void Return_View_Add_Player_Or_Redirect()
        {
            // Arrange
            Player player = new Player { Id = 0, Name = "Micky", Age = 33, Team = "Disney", Number = 4, Position = "Dancer" };

            // Act
            var result = teamController.AddPlayer("Team"); // Get Action
            var result2 = teamController.AddPlayer(player); // Post Action

            // Assert
            Assert.IsType<ViewResult>(result);

            var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result2);
            Assert.Equal("TeamInfo", redirectToActionResult.ActionName);
        }

        [Fact]
        public void Redirect_Update_Player_View()
        {
            // Arrange
            Player player = new Player { Id = 0, Name = "Micky", Age = 33, Team = "Disney", Number = 4, Position = "Dancer" };
            _context.Players.Add(player);

            // Act
            var result = teamController.UpdatePlayer(3);

            // Assert
            var okObjectResult = result as OkObjectResult;
            Assert.Null(okObjectResult);
        }
    }
}
