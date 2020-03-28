using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labsheet8;

namespace DataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            TeamData db = new TeamData();

            using (db)
            {
                Team t1 = new Team() { TeamID = 1, TeamName = "Ballina Town FC", Location = "Ballina" };
                Player p1 = new Player() { PlayerID = 1, Name = "Dave", Position = "Forward", TeamID = 1, team = t1 };
                Player p2 = new Player() { PlayerID = 2, Name = "Mick", Position = "Defender", TeamID = 1, team = t1 };

                Team t2 = new Team() { TeamID = 1, TeamName = "Sligo Rovers", Location = "Sligo" };
                Player p3 = new Player() { PlayerID = 1, Name = "Tom", Position = "GoalKeeper", TeamID = 2, team = t2 };
                Player p4 = new Player() { PlayerID = 2, Name = "Harry", Position = "Defender", TeamID = 2, team = t2 };

                db.teams.Add(t1);
                db.teams.Add(t2);

                Console.WriteLine("Added Teams to database ");

                db.players.Add(p1);
                db.players.Add(p2);
                db.players.Add(p3);
                db.players.Add(p4);

                Console.WriteLine("Added players to database");

                db.SaveChanges();

                Console.WriteLine("Saved to database");
            }
        }
    }
}
