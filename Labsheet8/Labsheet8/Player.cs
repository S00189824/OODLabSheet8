using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet8
{
    public class Player
    {
        public int PlayerID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }

        public int TeamID { get; set; }
        public virtual Team team { get; set; }
    }

    public class Team
    {
        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public string Location { get; set; }
        public string HomeGround { get; set; }

        public virtual List<Player> players { get; set; }
    }

    public class TeamData : DbContext
    {
        public TeamData() : base("MyTeamData") { }

        public DbSet<Player> players { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}
