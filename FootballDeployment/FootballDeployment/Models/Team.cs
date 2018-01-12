using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballDeployment.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Field { get; set; }
    }
}
