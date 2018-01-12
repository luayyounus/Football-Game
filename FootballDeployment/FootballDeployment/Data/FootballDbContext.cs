using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballDeployment.Models;
using Microsoft.EntityFrameworkCore;

namespace FootballDeployment.Data
{
    public class FootballDbContext : DbContext
    {
        public FootballDbContext(DbContextOptions<FootballDbContext> options) : base(options)
        {
            
        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}
