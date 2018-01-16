using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballDeployment.Data;
using FootballDeployment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FootballDeployment.Controllers
{
    public class HomeController : Controller
    {
        private FootballDbContext _context;

        public HomeController(FootballDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Team team)
        {
            if (!ModelState.IsValid)
                RedirectToAction("Index");

            if (!(_context.Teams.Any(t => t.Name == team.Name)))
            {
                //Add player to database
                _context.Teams.Add(team);
                //Saving the player to database
                _context.SaveChanges();
            }

            //Redirect to view team info
            return RedirectToAction("TeamInfo", "Team", new { teamName = team.Name});
        }
    }
}
