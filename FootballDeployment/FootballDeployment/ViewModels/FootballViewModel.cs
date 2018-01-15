using FootballDeployment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballDeployment.ViewModels
{
    public class FootballViewModel
    {
        public List<Player> Players { get; set; }
        public Team Team { get; set; }
    }
}
