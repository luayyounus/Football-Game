using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballDeployment.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte Age { get; set; }
        public byte Number { get; set; }
        public string Team { get; set; }
        public string Position { get; set; }
    }
}
