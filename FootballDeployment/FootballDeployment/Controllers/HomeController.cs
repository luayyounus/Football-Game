using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballDeployment.Data;
using FootballDeployment.Models;
using Microsoft.AspNetCore.Mvc;

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

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Player player)
        {
            //Add player to database
            _context.Players.Add(player);
            //Saving the player
            _context.SaveChanges();

            //Redirect to view team info
            return RedirectToAction("TeamInfo", "Team");
        }
    }
}
