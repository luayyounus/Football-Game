using System.Collections.Generic;
using System.Linq;
using FootballDeployment.Data;
using FootballDeployment.Models;
using FootballDeployment.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FootballDeployment.Controllers
{
    public class TeamController : Controller
    {
        private FootballDbContext _context;

        public TeamController(FootballDbContext context)
        {
            _context = context;
        }

        public IActionResult TeamInfo(string teamName)
        {
            Team team = _context.Teams.FirstOrDefault(t => t.Name == teamName);

            FootballViewModel footballViewModel = new FootballViewModel
            {
                Players = _context.Players.Where(p => p.Team == teamName).ToList(),
                Team = team
            };

            return View(footballViewModel);
        }

        [HttpGet]
        public IActionResult AllTeams()
        {
            List<Team> allTeams = _context.Teams.ToList();
            return View(allTeams);
        }

        [HttpGet]
        public IActionResult AddPlayer(string team)
        {
            ViewBag.Team = team;
            // return view of add player
            return View();
        }

        [HttpPost]
        public IActionResult AddPlayer(Player player)
        {
            // add player to database
            _context.Players.Add(player);
            // save player
            _context.SaveChanges();

            return RedirectToAction("TeamInfo", new { teamName = player.Team });
        }

        // return view of update player with id
        [HttpGet]
        public IActionResult UpdatePlayer(int id) => View(_context.Players.FirstOrDefault(p => p.Id == id));

        [HttpPost]
        public IActionResult UpdatePlayer(Player p)
        {
            // update player
            _context.Players.Update(p);
            _context.SaveChanges();

            return RedirectToAction("TeamInfo", new { teamName = p.Team });
        }

        // return view of specified player to delete
        [HttpGet]
        public IActionResult DeletePlayer(int id) => View(_context.Players.First(p => p.Id == id));        

        [HttpPost]
        public IActionResult DeletePlayer(Player p)
        {
            // remove player from the database
            _context.Remove(p);
            _context.SaveChanges();

            return RedirectToAction("TeamInfo", new { teamName = p.Team });
        }
    }
}
